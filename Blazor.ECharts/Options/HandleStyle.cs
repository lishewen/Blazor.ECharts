using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record HandleStyle : AreaStyle
    {
        /// <summary>
        /// 图形的描边颜色。支持的颜色格式同 color，不支持回调函数。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.handleStyle.borderColor ">此处</see>查看详细设置</para>
        /// </summary>
        public object BorderColor { set; get; }

        /// <summary>
        /// 描边线宽。为 0 时无描边。
        /// </summary>
        public int? BorderWidth { set; get; }

        /// <summary>
        /// 柱条的描边类型，默认为实线，支持 'solid', 'dashed', 'dotted'。
        /// </summary>
        public LineStyleType? BorderType { set; get; }
    }
}
