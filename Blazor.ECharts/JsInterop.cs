using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        private readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
        };

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
        public async ValueTask<IJSObjectReference> InitChart(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            var module = await moduleTask.Value;
            return await module.InvokeAsync<IJSObjectReference>("echartsFunctions.initChart", id);
        }

        /// <summary>
        /// 配置Echarts参数
        /// </summary>
        /// <param name="jsRuntime"></param>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="option">参数</param>
        /// <param name="notMerge">可选，是否不跟之前设置的 option 进行合并，默认为 false，即合并。</param>
        /// <returns></returns>
        public async Task SetupChart(string id, object option)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            if (option == null) throw new ArgumentNullException(nameof(option), "echarts参数不能为空");
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.setupChart", id, JsonSerializer.Serialize(option, jsonSerializerOptions));
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
