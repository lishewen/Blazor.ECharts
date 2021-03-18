using Blazor.ECharts.Options;
using Microsoft.AspNetCore.Components;
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

        [Parameter]
        public EChartsOption<T> Option { get; set; }
        [Parameter]
        public string OptionRaw { get; set; }
        /// <summary>
        /// 默认是否呈现组件
        /// </summary>
        [Parameter]
        public bool AutoRender { get; set; } = true;
        /// <summary>
        /// 主题
        /// </summary>
        [Parameter]
        public string Theme { get; set; } = "light";
        protected bool RequireRender { get; set; }
        [Inject]
        public JsInterop JsInterop { get; set; }
        [Parameter]
        public Func<object, Task> OnRenderCompleted { get; set; }

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
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (AutoRender == false) return;
            if (firstRender)
            {
                if (Option == null && string.IsNullOrWhiteSpace(OptionRaw)) return;

                if (!string.IsNullOrWhiteSpace(OptionRaw))
                    await JsInterop.SetupChart(Id, Theme, OptionRaw);
                else
                    await JsInterop.SetupChart(Id, Theme, Option);

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
