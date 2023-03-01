using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 事件参数
    /// </summary>
    public record EchartsEventArgs
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public EventType? EventType { get; set; }

        /// <summary>
        /// 当前点击的图形元素所属的组件名称，
        /// 其值如 'series'、'markLine'、'markPoint'、'timeLine' 等。
        /// </summary>
        public string ComponentType { get; set; }

        /// <summary>
        /// 系列类型。值可能为：'line'、'bar'、'pie' 等。当 componentType 为 'series' 时有意义。
        /// </summary>
        public string SeriesType { get; set; }

        /// <summary>
        /// 系列在传入的 option.series 中的 index。当 componentType 为 'series' 时有意义。
        /// </summary>
        public int SeriesIndex { get; set; }

        /// <summary>
        /// 系列名称。当 componentType 为 'series' 时有意义。
        /// </summary>
        public string SeriesName { get; set; }

        /// <summary>
        ///  数据名，类目名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据在传入的 data 数组中的 index
        /// </summary>
        public int DataIndex { get; set; }

        /// <summary>
        /// 传入的原始数据项
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// sankey、graph 等图表同时含有 nodeData 和 edgeData 两种 data，
        /// dataType 的值会是 'node' 或者 'edge'，表示当前点击在 node 还是 edge 上。
        /// 其他大部分图表中只有一种 data，dataType 无意义。
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 传入的数据值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 数据图形的颜色。当 componentType 为 'series' 时有意义。
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 用户自定义的数据。只在 graphic component 和自定义系列（custom series）
        /// 中生效，如果节点定义上设置了如：{type: 'circle', info: {some: 123}}。
        /// </summary>
        public object Info { get; set; }

        /// <summary>
        /// 当图标完全渲染的时候，获取图片的base64编码
        /// </summary>
        public string DataUrl { get; set; }

        /// <summary>
        /// batch
        /// </summary>
        public IEnumerable<EchartsEventBatch> Batch { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var property in GetType().GetProperties())
            {
                sb.Append($"{property.Name}:{property.GetValue(this)}; ");
            }
            return sb.ToString();
        }
    }
}
