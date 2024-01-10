using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    /// <summary>
    /// 可以定义 data 的哪个维度被编码成什么。
    /// </summary>
    public record Encode
    {
        public object X { get; set; }
        public object Y { get; set; }
        public object Tooltip { get; set; }
        /// <summary>
        /// 饼图使用
        /// </summary>
        public string ItemName { set; get; }
        /// <summary>
        /// 对于一些没有坐标系的图表，例如饼图、漏斗图等，可以是：
        /// </summary>
        public object Value { get; set; }
        public string SeriesName { get; set; }
        /// <summary>
        /// 单轴（singleAxis）特有的属性：
        /// </summary>
        public object Single { get; set; }
        /// <summary>
        /// 极坐标系（polar）特有的属性：
        /// </summary>
        public object Radius { get; set; }
        /// <summary>
        /// 极坐标系（polar）特有的属性：
        /// </summary>
        public object Angle { get; set; }
        /// <summary>
        ///  地理坐标系（geo）特有的属性：
        /// </summary>
        public double? Lng { get; set; }
        /// <summary>
        ///  地理坐标系（geo）特有的属性：
        /// </summary>
        public double? Lat { get; set; }
    }
}
