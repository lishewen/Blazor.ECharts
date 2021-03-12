using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class JsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public JsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/Blazor.ECharts/core.js").AsTask());
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        /// <summary>
        /// 初始化Echarts
        /// </summary>
        /// <param name="jsRuntime"></param>
        /// <param name="id">ECharts容器ID</param>
        /// <returns></returns>
        public async Task InitChart(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(id, "echarts控件id不能为空");
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.initChart", id);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
