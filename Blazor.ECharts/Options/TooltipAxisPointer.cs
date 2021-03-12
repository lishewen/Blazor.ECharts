using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 坐标轴指示器配置项。
    /// </summary>
    public class TooltipAxisPointer
    {
        /// <summary>
        /// 指示器类型。
        /// </summary>
        public AxisPointerType? Type { set; get; }

        /// <summary>
        /// 指示器的坐标轴
        /// </summary>
        public AxisPointerAxis? Axis { set; get; }

        /// <summary>
        /// 坐标轴指示器是否自动吸附到点上。默认自动判断。这个功能在数值轴和时间轴上比较有意义，可以自动寻找细小的数值点。
        /// </summary>
        public bool? Snap { set; get; }

        /// <summary>
        /// 坐标轴指示器的 z 值。控制图形的前后顺序。z值小的图形会被z值大的图形覆盖。
        /// </summary>
        public int? Z { set; get; }

        /// <summary>
        /// 坐标轴指示器的文本标签。
        /// </summary>
        public AxisPointerLabel Label { set; get; }

        /// <summary>
        /// 是否开启动画。
        /// </summary>
        public bool? Animation { set; get; }
    }

    /// <summary>
    /// 坐标轴指示器的文本标签
    /// </summary>
    public class AxisPointerLabel
    {
        /// <summary>
        /// 是否显示文本标签。如果 tooltip.axisPointer.type 设置为 'cross' 则默认显示标签，否则默认不显示。
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 文本标签中数值的小数点精度。默认根据当前轴的值自动判断。也可以指定如 2 表示保留两位小数。
        /// </summary>
        public int? Precision { set; get; }

        /// <summary>
        /// 文本标签的背景颜色，默认是和 axis.axisLine.lineStyle.color 相同。
        /// </summary>
        public string BackgroundColor { set; get; }
    }
}
