using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    public class ComponentBase<T> : ComponentBase, IAsyncDisposable where T : class
    {
        protected string Id = "echerts_" + Guid.NewGuid().ToString("N");
        private DotNetObjectReference<ComponentBase<T>> _objectReference;
        /// <summary>
        /// 主题
        /// </summary>
        [Parameter]
        public string Theme { get; set; }
        [Parameter]
        public EChartsOption<T> Option { get; set; }
        [Parameter]
        public string OptionRaw { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        /// <summary>
        /// 默认是否呈现组件
        /// </summary>
        [Parameter]
        public bool AutoRender { get; set; } = true;
        /// <summary>
        /// 是否响应Resize
        /// </summary>
        [Parameter]
        public bool ISResize { get; set; } = true;
        protected bool RequireRender { get; set; }
        [Inject]
        public JsInterop JsInterop { get; set; }
        [Parameter]
        public Func<object, Task> OnRenderCompleted { get; set; }

        /// <summary>
        /// 事件类型.
        /// </summary>
        [Parameter]
        public List<EventType> EventTypes { get; set; } = new List<EventType>();

        /// <summary>
        /// 事件回调函数
        /// </summary>
        [Parameter]
        public EventCallback<EchartsEventArgs> OnEventCallback { get; set; }

        private EventInvokeHelper _eventInvokeHelper;
        /// <summary>
        /// 有否绑定事件
        /// </summary>
        private bool hasBindEvent;

        /// <summary>
        /// 设置自定义样式
        /// </summary>
        [Parameter]
        public string Style { get; set; } = "min-width:300px;min-height:300px;";

        /// <summary>
        /// 设置class样式
        /// </summary>
        [Parameter]
        public string Class { get; set; }

        /// <summary>
        /// Whether or not in the prerender phase.
        /// The flag helps ensure that the JS interop is not carried out during the
        /// prerender phase when the hosting model is Blazor server.
        /// </summary>
        private bool IsPrerenderPhase { get; set; } = true;

        protected override void OnInitialized()
        {
            _eventInvokeHelper = new EventInvokeHelper(async echartsParams =>
            {
                if (EventTypes.Count > 0 && OnEventCallback.HasDelegate)
                    await OnEventCallback.InvokeAsync(echartsParams);
            });
            _objectReference = DotNetObjectReference.Create(this);
        }
        /// <summary>
        /// 默认情况下所有复杂组件都只进行一次渲染，该方法将组件置为需要再次渲染
        /// </summary>
        public void MarkAsRequireRender()
        {
            RequireRender = true;
        }
        protected override void OnAfterRender(bool firstRender)
        {
            RequireRender = false;
        }
        protected override bool ShouldRender()
        {
            return RequireRender;
        }
        protected override async Task OnParametersSetAsync()
        {
            if (IsPrerenderPhase) return;

            await SetupChartAsync();
        }

        private async Task SetupChartAsync()
        {
            if (Option == null && string.IsNullOrWhiteSpace(OptionRaw) && ChildContent == null) return;

            if (ChildContent != null)
            {
                var sb = new StringBuilder();
                var rtb = new RenderTreeBuilder();
                ChildContent.Invoke(rtb);
#pragma warning disable BL0006 // Do not use RenderTree types
                foreach (var frame in rtb.GetFrames().Array)
                {
                    if (frame.FrameType == RenderTreeFrameType.Markup)
                    {
                        sb.AppendLine(frame.MarkupContent);
                    }
                }
#pragma warning restore BL0006 // Do not use RenderTree types
                var output = sb.ToString().Trim();

                if (!string.IsNullOrWhiteSpace(output))
                    await JsInterop.SetupChart(Id, Theme, output);
            }
            else if (!string.IsNullOrWhiteSpace(OptionRaw))
                await JsInterop.SetupChart(Id, Theme, OptionRaw);
            else
                await JsInterop.SetupChart(Id, Theme, Option);

            // 事件
            if (EventTypes.Count > 0 && OnEventCallback.HasDelegate && !hasBindEvent)
            {
                foreach (var eventType in EventTypes)
                {
                    await JsInterop.ChartOn(Id, eventType, DotNetObjectReference.Create(_eventInvokeHelper));
                }
                hasBindEvent = true;
            }
            if (ISResize)
            {
                await AddResizeListener();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (AutoRender == false) return;
            if (firstRender)
            {
                IsPrerenderPhase = false;

                await SetupChartAsync();

                if (OnRenderCompleted != null)
                {
                    await OnRenderCompleted(this);
                }
            }
            RequireRender = false;
        }
        public async Task SetupOptionAsync(string opt, bool notMerge = false)
        {
            await JsInterop.SetupChart(Id, Theme, opt, notMerge);
        }
        public async Task SetupOptionAsync(EChartsOption<T> opt, bool notMerge = false)
        {
            await JsInterop.SetupChart(Id, Theme, opt, notMerge);
        }
        public async Task ResizeAsync()
        {
            await JsInterop.Resize(Id);
        }
        [JSInvokable("OnResize")]
        public void OnResize()
        {
            if (ISResize)
            {
                _ = ResizeAsync();
            }
        }
        private async Task AddResizeListener()
        {
            await JsInterop.InvokeVoidAsync("echartsFunctions.addResizeListener", _objectReference);
        }
        private async Task RemoveResizeListener()
        {
            await JsInterop.InvokeVoidAsync("echartsFunctions.removeResizeListener", _objectReference);
        }
        public void Refresh()
        {
            StateHasChanged();
        }

        public async ValueTask DisposeAsync()
        {
            if (IsPrerenderPhase) return;
            await RemoveResizeListener();
            _objectReference?.Dispose();
        }

        /// <summary>
        /// 显示加载UI
        /// </summary>
        /// <param name="option">加载UI选项，null则使用默认选项</param>
        public void ShowLoading(LoadingOption option = null)
        {
            _ = JsInterop.ChartShowLoading(Id, option?.ToString());
		}

        /// <summary>
        /// 隐藏加载选项
        /// </summary>
        public void HideLoading()
        {
            _ = JsInterop.ChartHideLoading(Id);
        }
    }
}
