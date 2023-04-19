using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record AreaStyle
    {
        /// <summary>
        /// 线的颜色
        /// </summary>
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.dataBackground.areaStyle.color ">此处</see>查看详细设置</para>
        public object Color { set; get; }

        /// <summary>
        /// 图形阴影的模糊大小。该属性配合 shadowColor,shadowOffsetX, shadowOffsetY 一起设置图形的阴影效果。
        /// </summary>
        public int? ShadowBlur { set; get; }

        /// <summary>
        /// 阴影颜色。支持的格式同color。
        /// </summary>
        public object ShadowColor { set; get; }

        /// <summary>
        /// 阴影水平方向上的偏移距离。
        /// </summary>
        public int? ShadowOffsetX { set; get; }

        /// <summary>
        /// 阴影垂直方向上的偏移距离。
        /// </summary>
        public int? ShadowOffsetY { set; get; }

        /// <summary>
        /// 图形透明度。支持从 0 到 1 的数字，为 0 时不绘制该图形。
        /// </summary>
        public double? Opacity { set; get; }

        /// <summary>
        /// 图形区域的起始位置。
        /// <para>默认情况下，图形会从坐标轴轴线到数据间进行填充。如果需要填充的区域是坐标轴最大值到数据间，或者坐标轴最小值到数据间，则可以通过这个配置项进行设置。</para>
        /// </summary>
        public Origin? Origin { set; get; }
    }
}
