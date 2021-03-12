using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 直角坐标系
    /// </summary>
    public class Axis
    {
        /// <summary>
        /// 坐标轴名称。
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 坐标轴名称显示位置。
        /// </summary>
        public Location? NameLocation { set; get; }

        /// <summary>
        /// 是否是反向坐标轴
        /// </summary>
        public bool? Inverse { set; get; }

        /// <summary>
        /// 坐标轴刻度最大值。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#yAxis.max ">此处</see>查看详细设置</para>
        /// </summary>
        public object Max { set; get; }

        /// <summary>
        /// 坐标轴刻度最小值。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#yAxis.min ">此处</see>查看详细设置</para>
        /// </summary>
        public object Min { set; get; }

        /// <summary>
        /// 坐标轴类型。
        /// <para>'time' 时间轴，适用于连续的时序数据，与数值轴相比时间轴带有时间的格式化，在刻度计算上也有所不同，例如会根据跨度的范围来决定使用月，星期，日还是小时范围的刻度。</para>
        /// <para>'log' 对数轴。适用于对数数据。</para>
        /// </summary>
        public AxisType? Type { set; get; }

        /// <summary>
        /// 类目数据，在类目轴（type: 'category'）中有效。
        /// <para>如果没有设置 type，但是设置了 axis.data，则认为 type 是 'category'。</para>
        /// <para>如果设置了 type 是 'category'，但没有设置 axis.data，则 axis.data 的内容会自动从 series.data 中获取，这会比较方便。不过注意，axis.data 指明的是 'category' 轴的取值范围。如果不指定而是从 series.data 中获取，那么只能获取到 series.data 中出现的值。比如说，假如 series.data 为空时，就什么也获取不到。</para>
        /// </summary>
        public object Data { set; get; }

        /// <summary>
        /// 坐标轴两边留白策略，类目轴和非类目轴的设置和表现不一样。
        /// <para>类目轴中 boundaryGap 可以配置为 true 和 false。默认为 true，这时候刻度只是作为分隔线，标签和数据点都会在两个刻度之间的带(band)中间。</para>
        /// <para>非类目轴，包括时间，数值，对数轴，boundaryGap是一个两个值的数组，分别表示数据最小值和最大值的延伸范围，可以直接设置数值或者相对的百分比，在设置 min 和 max 后无效。 示例：boundaryGap: ['20%', '20%']</para>
        /// </summary>
        public object BoundaryGap { set; get; }

        /// <summary>
        /// 坐标轴轴线相关设置。
        /// </summary>
        public AxisLine AxisLine { set; get; }

        /// <summary>
        /// x或y 轴所在的 grid 的索引，默认位于第一个 grid。
        /// </summary>
        public int? GridIndex { set; get; }

        /// <summary>
        /// 坐标轴在 grid 区域中的分隔线。
        /// </summary>
        public SplitLine SplitLine { set; get; }

        /// <summary>
        /// 坐标轴刻度标签的相关设置。
        /// </summary>
        public AxisLabel AxisLabel { set; get; }

        /// <summary>
        /// 坐标轴是否是静态无法交互。
        /// </summary>
        public bool? Silent { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Scale { set; get; }

        /// <summary>
        /// 坐标轴的分割段数，需要注意的是这个分割段数只是个预估值，最后实际显示的段数会在这个基础上根据分割后坐标轴刻度显示的易读程度作调整。
        /// </summary>
        public int? SplitNumber { set; get; }

        public AxisPointer AxisPointer { set; get; }

        public AxisTick AxisTick { set; get; }

        public SplitArea SplitArea { set; get; }
    }
    public class XAxis : Axis
    {

        /// <summary>
        /// x 轴的位置。
        /// </summary>
        public PositionX? Position { set; get; }
    }
    public class YAxis : Axis
    {

        /// <summary>
        /// y 轴的位置。
        /// </summary>
        public PositionY? Position { set; get; }
    }
    public class AxisTick
    {
        public bool? AlignWithLabel { set; get; }
        public bool? Show { set; get; }
    }
    public class AxisLabel
    {
        /// <summary>
        /// 刻度标签的内容格式器，支持字符串模板和回调函数两种形式。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#xAxis.axisLabel.formatter">此处</see>查看详细设置</para>
        /// </summary>
        public object Formatter { set; get; }

        public bool? Show { set; get; }
    }

    /// <summary>
    /// 坐标轴轴线相关设置。
    /// </summary>
    public class AxisLine
    {
        public bool? Show { set; get; }

        /// <summary>
        /// X 轴或者 Y 轴的轴线是否在另一个轴的 0 刻度上，只有在另一个轴为数值轴且包含 0 刻度时有效。
        /// </summary>
        public bool? OnZero { set; get; }

        public LineStyle LineStyle { set; get; }
    }
}
