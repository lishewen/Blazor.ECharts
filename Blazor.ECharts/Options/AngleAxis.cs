using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 极坐标系的角度轴。
    /// </summary>
    public class AngleAxis
    {
        /// <summary>
        /// 坐标轴类型。
        /// </summary>
        public AxisType? Type { set; get; }

        /// <summary>
        /// 起始刻度的角度，默认为 90 度，即圆心的正上方。0 度为圆心的正右方。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#angleAxis.startAngle">此处</see>查看详细设置</para>
        /// </summary>
        public int? StartAngle { set; get; }
    }
}
