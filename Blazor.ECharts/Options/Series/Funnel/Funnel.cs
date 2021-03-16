using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Funnel
{
    /// <summary>
    /// 漏斗图
    /// </summary>
    public record Funnel : SeriesBase, IPosition
    {
        public Funnel() : base("funnel") { }
        /// <summary>
        /// 漏斗图组件离容器左侧的距离。
        /// left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。
        /// 如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。
        /// </summary>
        public object Left { get; set; }
        /// <summary>
        /// 漏斗图组件离容器上侧的距离。
        /// top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
        /// 如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
        /// </summary>
        public object Top { get; set; }
        /// <summary>
        /// 漏斗图组件离容器右侧的距离。
        /// right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        /// </summary>
        public object Right { get; set; }
        /// <summary>
        /// 漏斗图组件离容器下侧的距离。
        /// bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        /// </summary>
        public object Bottom { get; set; }
        /// <summary>
        /// 漏斗图组件的宽度。默认自适应。
        /// </summary>
        public object Width { get; set; }
        /// <summary>
        /// 漏斗图组件的高度。默认自适应。
        /// </summary>
        public object Height { get; set; }
        /// <summary>
        /// 指定的数据最小值。
        /// </summary>
        public int Min { get; set; } = 0;
        /// <summary>
        /// 指定的数据最大值。
        /// </summary>
        public int Max { get; set; } = 100;
        /// <summary>
        /// 数据最小值 min 映射的宽度。
        /// 可以是绝对的像素大小，也可以是相对布局宽度的百分比，如果需要最小值的图形并不是尖端三角，可通过设置该属性实现。
        /// </summary>
        public string MinSize { get; set; }
        /// <summary>
        /// 数据最大值 max 映射的宽度。
        /// 可以是绝对的像素大小，也可以是相对布局宽度的百分比。
        /// </summary>
        public string MaxSize { get; set; }
        /// <summary>
        /// 数据排序
        /// </summary>
        public SortType Sort { get; set; }
        /// <summary>
        /// 数据图形间距。
        /// </summary>
        public int Gap { get; set; } = 0;
        /// <summary>
        /// 漏斗图图形上的文本标签，可用于说明图形的一些数据信息，比如值，名称等。
        /// </summary>
        public Label Label { set; get; }
        /// <summary>
        /// 图形样式。
        /// </summary>
        public ItemStyle ItemStyle { set; get; }
        /// <summary>
        /// 高亮的标签和图形样式。
        /// </summary>
        public Emphasis Emphasis { set; get; }
    }
}
