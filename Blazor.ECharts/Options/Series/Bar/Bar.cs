using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Bar
{
    /// <summary>
    /// 柱状图
    /// </summary>
    public record Bar : SeriesBase
    {
        public Bar() : base("bar") { }

        /// <summary>
        /// 是否平滑曲线显示。
        /// <para>如果是 boolean 类型，则表示是否开启平滑处理。如果是 number 类型（取值范围 0 到 1），表示平滑程度，越小表示越接近折线段，反之则反。设为 true 时相当于设为 0.5。</para>
        /// <para>如果需要修改平滑算法，请参考 smoothMonotone。</para>
        /// </summary>
        public object Smooth { set; get; }

        /// <summary>
        /// 同一系列的柱间距离，默认为类目间距的20%，可设固定值.在同一坐标系上，此属性会被多个 'bar' 系列共享。此属性应设置于此坐标系中最后一个 'bar' 系列上才会生效，并且是对此坐标系中所有 'bar' 系列生效。
        /// </summary>
        public object BarCategoryGap { set; get; }

        public object LineStyle { set; get; }

        public ItemStyle ItemStyle { set; get; }

        /// <summary>
        /// 坐标轴是否是静态无法交互。
        /// </summary>
        public bool? Silent { get; set; }

        /// <summary>
        /// 不同系列的柱间距离，为百分比（如 '30%'，表示柱子宽度的 30%）。
        /// 如果想要两个系列的柱子重叠，可以设置 barGap 为 '-100%'。这在用柱子做背景的时候有用。
        /// 在同一坐标系上，此属性会被多个 'bar' 系列共享。此属性应设置于此坐标系中最后一个 'bar' 系列上才会生效，并且是对此坐标系中所有 'bar' 系列生效。
        /// </summary>
        public string BarGap { get; set; }

        /// <summary>
        /// z 方向的高度，决定层叠关系。
        /// </summary>
        public int? Z { set; get; }

        /// <summary>
        /// 使用的 x 轴的 index，在单个图表实例中存在多个 x 轴的时候有用。
        /// </summary>
        public int? XAxisIndex { set; get; }

        /// <summary>
        /// 使用的 y 轴的 index，在单个图表实例中存在多个 y轴的时候有用。
        /// </summary>
        public int? YAxisIndex { set; get; }
        /// <summary>
        /// 柱条的宽度，不设时自适应。
        /// 可以是绝对值例如 40 或者百分数例如 '60%'。百分数基于自动计算出的每一类目的宽度。
        /// 在同一坐标系上，此属性会被多个 'bar' 系列共享。此属性应设置于此坐标系中最后一个 'bar' 系列上才会生效，并且是对此坐标系中所有 'bar' 系列生效。
        /// </summary>
        public string BarWidth { get; set; }
        /// <summary>
        /// 柱条的最大宽度。
        /// 比 barWidth 优先级高。
        /// 可以是绝对值例如 40 或者百分数例如 '60%'。百分数基于自动计算出的每一类目的宽度。
        /// 在同一坐标系上，此属性会被多个 'bar' 系列共享。此属性应设置于此坐标系中最后一个 'bar' 系列上才会生效，并且是对此坐标系中所有 'bar' 系列生效。
        /// </summary>
        public string BarMaxWidth { get; set; }

        public Encode Encode { get; set; }

        /// <summary>
        //数据堆叠，同个类目轴上系列配置相同的 stack 值可以堆叠放置。关于如何定制数值的堆叠方式，参见 stackStrategy。
        //注：目前 stack 只支持堆叠于 'value' 和 'log' 类型的类目轴上，不支持 'time' 和 'category' 类型的类目轴。        
        /// </summary>
        public string Stack { get; set; }
    }
}
