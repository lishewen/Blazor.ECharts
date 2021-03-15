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

        /// <summary>
        /// 使用的 x 轴的 index，在单个图表实例中存在多个 x 轴的时候有用。
        /// </summary>
        public int? XAxisIndex { set; get; }

        /// <summary>
        /// 使用的 y 轴的 index，在单个图表实例中存在多个 y轴的时候有用。
        /// </summary>
        public int? YAxisIndex { set; get; }

        public string BarWidth { get; set; }

        public Encode Encode { get; set; }
    }
}
