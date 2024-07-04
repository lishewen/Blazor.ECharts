using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.JSInterop;
using Microsoft.VisualBasic;
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
        public readonly string Id = "echerts_" + Guid.NewGuid().ToString("N");
        private DotNetObjectReference<ComponentBase<T>> _objectReference;
        private string _theme;
        /// <summary>
        /// 主题
        /// </summary>
#pragma warning disable BL0007
        [Parameter]
        public string Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                // 当主题值有改变时，销毁原Chart实例，让其重新加载，以达到切换主题的目的
                _ = JsInterop.DisposeChart(Id);
            }
        }
#pragma warning restore BL0007
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
        public List<EventType> EventTypes { get; set; } = [];

        /// <summary>
        /// 事件回调函数
        /// </summary>
        [Parameter]
        public EventCallback<EchartsEventArgs> OnEventCallback { get; set; }
        /// <summary>
        /// 自定义resize事件
        /// </summary>
        [Parameter]
        public EventCallback OnResizeEventCallback { get; set; }

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
        /// 可选。是否不跟之前设置的 option 进行合并。默认为 false。即表示合并。合并的规则，详见 组件合并模式。如果为 true，表示所有组件都会被删除，然后根据新 option 创建所有新组件。
        /// </summary>
        [Parameter]
        public bool NotMerge { get; set; } = false;
        /// <summary>
        /// 可选。用户可以在这里指定一个或多个组件，如：xAxis, series，这些指定的组件会进行 "replaceMerge"。如果用户想删除部分组件，也可使用 "replaceMerge"。详见 组件合并模式。
        /// </summary>
        [Parameter]
        public string[] ReplaceMerge { get; set; } = [];
        /// <summary>
        /// 可选。在设置完 option 后是否不立即更新图表，默认为 false，即同步立即更新。如果为 true，则会在下一个 animation frame 中，才更新图表。
        /// </summary>
        [Parameter]
        public bool LazyUpdate { get; set; } = false;
        /// <summary>
        /// 可选。阻止调用 setOption 时抛出事件，默认为 false，即抛出事件。
        /// </summary>
        [Parameter]
        public bool Silent { get; set; } = false;

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
                    await JsInterop.SetupChart(Id, Theme, output, new EChartsSetupOption
                    {
                        NotMerge = NotMerge,
                        ReplaceMerge = ReplaceMerge,
                        LazyUpdate = LazyUpdate,
                        Silent = Silent
                    }.ToString());
            }
            else if (!string.IsNullOrWhiteSpace(OptionRaw))
                await JsInterop.SetupChart(Id, Theme, OptionRaw, new EChartsSetupOption
                {
                    NotMerge = NotMerge,
                    ReplaceMerge = ReplaceMerge,
                    LazyUpdate = LazyUpdate,
                    Silent = Silent
                }.ToString());
            else
                await JsInterop.SetupChart(Id, Theme, Option, new EChartsSetupOption
                {
                    NotMerge = NotMerge,
                    ReplaceMerge = ReplaceMerge,
                    LazyUpdate = LazyUpdate,
                    Silent = Silent
                });
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
                await RemoveResizeListener();
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
        public async Task SetupOptionAsync(string opt)
        {
            await JsInterop.SetupChart(Id, Theme, opt, new EChartsSetupOption { NotMerge = NotMerge, ReplaceMerge = ReplaceMerge, LazyUpdate = LazyUpdate, Silent = Silent }.ToString());
        }
        public async Task SetupOptionAsync(EChartsOption<T> opt)
        {
            await JsInterop.SetupChart(Id, Theme, opt, new EChartsSetupOption
            {
                NotMerge = NotMerge,
                ReplaceMerge = ReplaceMerge,
                LazyUpdate = LazyUpdate,
                Silent = Silent
            });
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
                if (OnResizeEventCallback.HasDelegate)
                {
                    _ = OnResizeEventCallback.InvokeAsync();
                }
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
        /// <summary>
        /// 注入.net类型和方法
        /// </summary>
        /// <typeparam name="TD"></typeparam>
        /// <param name="dotNetObject"></param>
        public async Task AssignDotNetHelper<TD>(DotNetObjectReference<TD> dotNetObject) where TD : class
        {
            await JsInterop.InvokeVoidAsync("echartsFunctions.assignDotNetHelper", Id, dotNetObject);
        }
        /// <summary>
        /// 显示加载UI
        /// </summary>
        /// <param name="option">加载UI选项，null则使用默认选项</param>
        public void ShowLoading(LoadingOption option = null)
        {
            _ = JsInterop.ChartShowLoading(Id, opts: option);
        }

        /// <summary>
        /// 隐藏加载选项
        /// </summary>
        public void HideLoading()
        {
            _ = JsInterop.ChartHideLoading(Id);
        }
        /// <summary>
        /// 清空当前实例，会移除实例中所有的组件和图表。
        /// </summary>
        public void Clear()
        {
            _ = JsInterop.ClearChart(Id);
        }
        /// <summary>
        /// 触发图表行为
        /// </summary>
        /// <param name="option"></param>
        public void DispatchAction(DispatchActionOption option)
        {
            _ = JsInterop.DispatchAction(Id, option);
        }
        /// <summary>
        /// 转换坐标系上的点到像素坐标值
        /// </summary>
        /// <param name="finder"></param>
        /// <param name="value"></param>
        public async ValueTask<TN> ConvertToPixel<TN>(string finder, object value)
        {
            return await JsInterop.ConvertToPixel<TN>(Id, finder, value);
        }
        /// <summary>
        /// 转换像素坐标值到逻辑坐标系上的点。是 convertToPixel 的逆运算。
        /// </summary>
        /// <typeparam name="TN">Array|number</typeparam>
        /// <param name="finder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async ValueTask<TN> ConvertFromPixel<TN>(string finder, object value)
        {
            return await JsInterop.ConvertFromPixel<TN>(Id, finder, value);
        }
        /// <summary>
        /// 导出图表图片，返回一个 base64 的 URL，可以设置为Image的src。
        /// </summary>
        /// <param name="opts"></param>
        /// <returns></returns>
        public async ValueTask<string> GetDataURL(DataURLOption opts)
        {
            return await JsInterop.GetDataURL(Id, opts);
        }
        public async ValueTask DisposeAsync()
        {
            if (IsPrerenderPhase) return;
            await RemoveResizeListener();
            _objectReference?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
