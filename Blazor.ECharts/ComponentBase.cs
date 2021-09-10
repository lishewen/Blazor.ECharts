using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    public class ComponentBase<T> : ComponentBase
    {
        protected string Id = "echerts_" + Guid.NewGuid().ToString("N");
        /// <summary>
        /// 主题
        /// </summary>
        [Parameter]
        public string Theme { get; set; }
        [Parameter]
        public EChartsOption<T> Option { get; set; }
        [Parameter]
        public string OptionRaw { get; set; }
        /// <summary>
        /// 默认是否呈现组件
        /// </summary>
        [Parameter]
        public bool AutoRender { get; set; } = true;
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
        /// 设置自定义样式
        /// </summary>
        [Parameter]
        public string Style { get; set; } = "min-width:300px;min-height:300px;";

        /// <summary>
        /// 设置class样式
        /// </summary>
        [Parameter]
        public string Class { get; set; }
        protected override void OnInitialized()
        {
            _eventInvokeHelper = new EventInvokeHelper(async echartsParams =>
            {
                if (EventTypes.Count > 0 && OnEventCallback.HasDelegate)
                    await OnEventCallback.InvokeAsync(echartsParams);
            });
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
            if (Option == null && string.IsNullOrWhiteSpace(OptionRaw)) return;

            if (!string.IsNullOrWhiteSpace(OptionRaw))
                await JsInterop.SetupChart(Id, Theme, OptionRaw);
            else
                await JsInterop.SetupChart(Id, Theme, Option);
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (AutoRender == false) return;
            if (firstRender)
            {
                await OnParametersSetAsync();
                // 事件
                if (EventTypes.Count > 0 && OnEventCallback.HasDelegate)
                {
                    foreach (var eventType in EventTypes)
                    {
                        await JsInterop.ChartOn(Id, eventType, DotNetObjectReference.Create(_eventInvokeHelper));
                    }
                }

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
        public void Refresh()
        {
            StateHasChanged();
        }
    }
}
