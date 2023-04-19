using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record VisualMapPiecewise
    {
        public bool? Show { set; get; }

        /// <summary>
        /// visualMap 组件离容器上侧的距离。top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
        /// </summary>
        public object Top { set; get; }

        /// <summary>
        /// visualMap 组件离容器右侧的距离。。right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        /// </summary>
        public object Right { set; get; }

        /// <summary>
        /// 自定义『分段式视觉映射组件（visualMapPiecewise）』的每一段的范围，以及每一段的文字，以及每一段的特别的样式。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#visualMap-piecewise.pieces">此处</see>查看详细设置</para>
        /// </summary>
        public List<object> Pieces { set; get; }

        /// <summary>
        /// 定义 在选中范围外 的视觉元素。（用户可以和 visualMap 组件交互，用鼠标或触摸选择范围）
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#visualMap-piecewise.outOfRange">此处</see>查看详细设置</para>
        /// </summary>
        public OutOfRange OutOfRange { set; get; }

        /// <summary>
        /// 指定取哪个系列的数据，即哪个系列的 series.data。
        /// </summary>
        public object SeriesIndex { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? Dimension { set; get; }

        /// <summary>
        /// 指定 visualMapContinuous 组件的允许的最小值。'min' 必须用户指定。[visualMap.min, visualMax.max] 形成了视觉映射的『定义域』。
        /// </summary>
        public int? Min { set; get; }

        /// <summary>
        /// 指定 visualMapContinuous 组件的允许的最大值。'max' 必须用户指定。[visualMap.min, visualMax.max] 形成了视觉映射的『定义域』。
        /// </summary>
        public int? Max { set; get; }

        /// <summary>
        /// 两端的文本
        /// </summary>
        public string[] Text { set; get; }

        /// <summary>
        /// 拖拽时，是否实时更新。
        /// <para>如果为ture则拖拽手柄过程中实时更新图表视图。</para>
        /// <para>如果为false则拖拽结束时，才更新视图。</para>
        /// </summary>
        public bool? Realtime { set; get; }

        /// <summary>
        /// 是否显示拖拽用的手柄（手柄能拖拽调整选中范围）。
        /// </summary>
        public bool? Calculable { set; get; }

        /// <summary>
        /// 定义 在选中范围中 的视觉元素。（用户可以和 visualMap 组件交互，用鼠标或触摸选择范围）
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#visualMap-continuous.inRange">此处</see>查看详细设置</para>
        /// </summary>
        public object InRange { set; get; }
    }
    public record OutOfRange
    {
        /// <summary>
        /// 图元的颜色。
        /// </summary>
        public object Color { set; get; }
    }
}
