using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 可选配置项
    /// </summary>
    public record EChartsSetupOption
    {
        /// <summary>
        /// 可选。是否不跟之前设置的 option 进行合并。默认为 false。即表示合并。合并的规则，详见 组件合并模式。如果为 true，表示所有组件都会被删除，然后根据新 option 创建所有新组件。
        /// </summary>
        public bool NotMerge { get; set; }
        /// <summary>
        /// 可选。用户可以在这里指定一个或多个组件，如：xAxis, series，这些指定的组件会进行 "replaceMerge"。如果用户想删除部分组件，也可使用 "replaceMerge"。详见 组件合并模式。
        /// </summary>
        public string[] ReplaceMerge { get; set; }
        /// <summary>
        /// 可选。在设置完 option 后是否不立即更新图表，默认为 false，即同步立即更新。如果为 true，则会在下一个 animation frame 中，才更新图表。
        /// </summary>
        public bool LazyUpdate { get; set; }
        /// <summary>
        /// 可选。阻止调用 setOption 时抛出事件，默认为 false，即抛出事件。
        /// </summary>
        public bool Silent { get; set; }
        public override string ToString()
        {
            return EChartsOptionSerializer.Default.Serialize(this);
        }
    }
}
