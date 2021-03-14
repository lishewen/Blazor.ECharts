using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    /// <summary>
    /// 图表标线。
    /// </summary>
    public class MarkLine
    {
        /// <summary>
        /// 图形是否不响应和触发鼠标事件，默认为 false，即响应和触发鼠标事件。
        /// </summary>
        public bool? Silent { set; get; }

        /// <summary>
        /// 标线两端的标记类型，可以是一个数组分别指定两端，也可以是单个统一指定，具体格式见 data.symbol。
        /// </summary>
        public object Symbol { set; get; }

        /// <summary>
        /// 标线的数据数组。
        /// </summary>
        public List<object> Data { set; get; }
    }
    public class MarkLineData
    {
        public string Name { set; get; }

        public object YAxis { set; get; }

        public object X { set; get; }

        public string Symbol { set; get; }

        public Sampling? Type { set; get; }

        public MarkLineDataLabel Label { set; get; }

        /// <summary>
        /// 在使用 type 时有效，用于指定在哪个维度上指定最大值最小值。这可以是维度的直接名称，例如折线图时可以是x、angle等、candlestick 图时可以是open、close等维度名称。
        /// </summary>
        public string ValueDim { set; get; }

        /// <summary>
        /// 起点标记的大小，可以设置成诸如 10 这样单一的数字，也可以用数组分开表示宽和高，例如 [20, 10] 表示标记宽为20，高为10。
        /// </summary>
        public object SymbolSize { set; get; }

        public Emphasis Emphasis { set; get; }
    }

    public class MarkLineDataLabel
    {
        public bool? Show { set; get; }

        /// <summary>
        /// 标签位置
        /// </summary>
        public Location? Position { set; get; }

        /// <summary>
        /// 标签内容格式器，支持字符串模板和回调函数两种形式，字符串模板与回调函数返回的字符串均支持用 \n 换行。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-line.markLine.data.1.label.formatter">此处</see>查看详细设置</para>
        /// </summary>
        public object Formatter { set; get; }
    }
}
