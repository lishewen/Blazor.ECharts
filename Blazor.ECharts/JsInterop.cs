using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;

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
        /// <param name="id">ECharts容器ID</param>
        /// <param name="theme">主题</param>
        /// <returns></returns>
        public async ValueTask<IJSObjectReference> InitChart(string id, string theme = "light")
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            var module = await moduleTask.Value;
            return await module.InvokeAsync<IJSObjectReference>("echartsFunctions.initChart", id, theme);
        }
        public async Task RegisterMap(string name, string svg)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.registerMap", name, svg);
        }
        /// <summary>
        /// 配置Echarts参数
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="theme">主题</param>
        /// <param name="option">参数</param>
        /// <returns></returns>
        public async Task SetupChart<T>(string id, string theme, EChartsOption<T> option, bool notMerge = false)
        {
            await SetupChart(id, theme, option.ToString(), notMerge);
        }

        /// <summary>
        /// 配置Echarts参数
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="theme">主题</param>
        /// <param name="option">参数</param>
        /// <returns></returns>
        public async Task SetupChart(string id, string theme, string option, bool notMerge = false)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            if (option == null) throw new ArgumentNullException(nameof(option), "echarts参数不能为空");
            if (string.IsNullOrWhiteSpace(theme)) theme = "light";
            var module = await moduleTask.Value;
            try
            {
                await module.InvokeVoidAsync("echartsFunctions.setupChart", id, theme, option, notMerge);
            }
            catch
            {
                Console.WriteLine("id:" + id);
                Console.WriteLine("theme:" + theme);
                Console.WriteLine("option:" + option);
                Console.WriteLine("notMerge:" + notMerge);
            }
        }

        /// <summary>
        /// 自适应
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task Resize(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.resize", id);
        }

        public async Task ChartOn(string id, EventType eventType, DotNetObjectReference<EventInvokeHelper> objectReference)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.on", id, eventType.ToString(), objectReference);
        }

        /// <summary>
        /// 显示加载动画效果。可以在加载数据前手动调用该接口显示加载动画，在数据加载完成后调用 hideLoading 隐藏加载动画。
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="type">加载动画类型，目前只有一种'default'</param>
        /// <param name="opts">加载动画配置项，跟type有关，下面是默认配置项</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task ShowLoading(string id, string type = "default", LoadingOption opts = null)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            if (opts == null) opts = new LoadingOption();
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.showLoading", id, type, opts.ToString());
        }

        /// <summary>
        /// 隐藏动画加载效果。
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task HideLoading(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.hideLoading", id);
        }
#nullable enable
        /// <summary>
        /// 透明传递
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async ValueTask InvokeVoidAsync(string identifier, params object?[] args)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync(identifier, args);
        }
#nullable disable

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
