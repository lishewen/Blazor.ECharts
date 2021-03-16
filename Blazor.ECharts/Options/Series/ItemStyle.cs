using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    public record ItemStyle
    {
        /// <summary>
        /// 图形的颜色。 默认从全局调色盘 option.color 获取颜色。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-line.itemStyle.color">此处</see>查看详细设置</para>
        /// </summary>
        public object Color { set; get; }

        public object Color0 { set; get; }

        /// <summary>
        /// 图形的描边颜色。支持的颜色格式同 color，不支持回调函数。
        /// </summary>
        public object BorderColor { set; get; }

        public int? BorderWidth { set; get; }

        /// <summary>
        /// 图形的描边颜色。支持的颜色格式同 color，不支持回调函数。
        /// </summary>
        public object BorderColor0 { set; get; }

        /// <summary>
        /// 描边线宽。为 0 时无描边。
        /// </summary>
        public int? TextBorderWidth { set; get; }

        /// <summary>
        /// 柱条的描边类型，默认为实线，支持 'solid', 'dashed', 'dotted'。
        /// </summary>
        public LineStyleType? BorderType { set; get; }

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
    }
}
