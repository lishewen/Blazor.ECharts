using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 这是坐标轴指示器（axisPointer）的全局公用设置。
    /// </summary>
    public class AxisPointer
    {
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 默认不显示。但是如果 tooltip.trigger 设置为 'axis' 或者 tooltip.axisPointer.type 设置为 'cross'，则自动显示 axisPointer。坐标系会自动选择显示显示哪个轴的 axisPointer，也可以使用 tooltip.axisPointer.axis 改变这种选择。
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 指示器类型。
        /// </summary>
        public AxisPointerType? Type { set; get; }

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
        /// 不同轴的 axisPointer 可以进行联动，在这里设置。联动表示轴能同步一起活动。轴依据他们的 axisPointer 当前对应的值来联动。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#axisPointer.link">此处</see>查看详细设置</para>
        /// </summary>
        public AxisPointerLink Link { set; get; }
    }
    public class AxisPointerLink
    {
        #region X
        public object XAxis { set; get; }
        public object XAxisId { set; get; }
        public object XAxisName { set; get; }
        public object XAxisIndex { set; get; }
        #endregion
        #region Y
        public object YAxis { set; get; }
        public object YAxisId { set; get; }
        public object YAxisName { set; get; }
        public object YAxisIndex { set; get; }
        #endregion
        #region Radius
        public object RadiusAxis { set; get; }
        public object RadiusAxisId { set; get; }
        public object RadiusAxisName { set; get; }
        public object RadiusAxisIndex { set; get; }
        #endregion
        #region Angle
        public object AngleAxis { set; get; }
        public object AngleAxisId { set; get; }
        public object AngleAxisName { set; get; }
        public object AngleAxisIndex { set; get; }
        #endregion
        #region Single
        public object SingleAxis { set; get; }
        public object SingleAxisId { set; get; }
        public object SingleAxisName { set; get; }
        public object SingleAxisIndex { set; get; }
        #endregion
    }
}
