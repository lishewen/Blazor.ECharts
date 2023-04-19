using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    /// <summary>
    /// 图表标注。
    /// </summary>
    public class MarkPoint
    {

        /// <summary>
        /// 标注的数据数组。每个数组项是一个对象，有下面几种方式指定标注的位置。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.markPoint.data">此处</see>查看详细设置</para>
        /// </summary>
        public List<MarkPointData> Data { set; get; }

        public Label Label { set; get; }

        public Tooltip Tooltip { set; get; }
    }
    /// <summary>
    /// 标注的数据数组。每个数组项是一个对象，有下面几种方式指定标注的位置。
    /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.markPoint.data">此处</see>查看详细设置</para>
    /// </summary>
    public class MarkPointData
    {
        /// <summary>
        /// 标注名称。
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 特殊的标注类型，用于标注最大值最小值等。
        /// </summary>
        public MarkPointDataType? Type { set; get; }

        /// <summary>
        /// 标注值，可以不设。
        /// </summary>
        public int? Value { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? XAxis { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? YAxis { set; get; }

        /// <summary>
        /// 在使用 type 时有效，用于指定在哪个维度上指定最大值最小值。这可以是维度的直接名称，例如折线图时可以是x、angle等、candlestick 图时可以是open、close等维度名称。
        /// </summary>
        public string ValueDim { set; get; }
    }
}
