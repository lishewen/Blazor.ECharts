using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 直角坐标系内绘图网格，单个 grid 内最多可以放置上下两个 X 轴，左右两个 Y 轴。可以在网格上绘制折线图，柱状图，散点图（气泡图）。
    /// </summary>
    public record Grid : IPosition
    {
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 所有图形的 zlevel 值。
        /// <para>zlevel用于 Canvas 分层，不同zlevel值的图形会放置在不同的 Canvas 中，Canvas 分层是一种常见的优化手段。我们可以把一些图形变化频繁（例如有动画）的组件设置成一个单独的zlevel。需要注意的是过多的 Canvas 会引起内存开销的增大，在手机端上需要谨慎使用以防崩溃。</para>
        /// <para>zlevel 大的 Canvas 会放在 zlevel 小的 Canvas 的上面。</para>
        /// </summary>
        public int? Zlevel { set; get; }

        /// <summary>
        /// 组件的所有图形的z值。控制图形的前后顺序。z值小的图形会被z值大的图形覆盖。
        /// <para>z相比zlevel优先级更低，而且不会创建新的 Canvas。</para>
        /// </summary>
        public int? Z { set; get; }

        /// <summary>
        /// grid 组件离容器左侧的距离。
        /// <para>left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。</para>
        /// <para>如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。</para>
        /// </summary>
        public object Left { set; get; }

        /// <summary>
        /// grid 组件离容器上侧的距离。
        /// <para>top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。</para>
        /// <para>如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。</para>
        /// </summary>
        public object Top { set; get; }

        /// <summary>
        /// grid 组件离容器右侧的距离。
        /// <para>right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。</para>
        /// </summary>
        public object Right { set; get; }

        /// <summary>
        /// grid 组件离容器下侧的距离。
        /// <para>bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。</para>
        /// </summary>
        public object Bottom { set; get; }

        /// <summary>
        /// 图例组件的宽度。默认自适应。
        /// </summary>
        public object Width { set; get; }

        /// <summary>
        /// 图例组件的高度。默认自适应。
        /// </summary>
        public object Height { set; get; }

        /// <summary>
        /// grid 区域是否包含坐标轴的刻度标签。
        /// </summary>
        public bool? ContainLabel { set; get; }

        /// <summary>
        /// 图例背景色，默认透明。
        /// <para>颜色可以使用 RGB 表示，比如 'rgb(128, 128, 128)' ，如果想要加上 alpha 通道，可以使用 RGBA，比如 'rgba(128, 128, 128, 0.5)'，也可以使用十六进制格式，比如 '#ccc'</para>
        /// </summary>
        public string BackgroundColor { set; get; }

        /// <summary>
        /// 图例的边框颜色。
        /// <para>颜色可以使用 RGB 表示，比如 'rgb(128, 128, 128)' ，如果想要加上 alpha 通道，可以使用 RGBA，比如 'rgba(128, 128, 128, 0.5)'，也可以使用十六进制格式，比如 '#ccc'</para>
        /// </summary>
        public string BorderColor { set; get; }

        /// <summary>
        /// 图例的边框线宽。
        /// </summary>
        public int? BorderWidth { set; get; }

        /// <summary>
        /// 图形阴影的模糊大小。该属性配合 shadowColor,shadowOffsetX, shadowOffsetY 一起设置图形的阴影效果。
        /// </summary>
        public int? ShadowBlur { set; get; }

        /// <summary>
        /// 阴影颜色。支持的格式同color。
        /// <para>注意：此配置项生效的前提是，设置了 show: true。</para>
        /// </summary>
        public object ShadowColor { set; get; }

        /// <summary>
        /// 阴影水平方向上的偏移距离。
        /// <para>注意：此配置项生效的前提是，设置了 show: true。</para>
        /// </summary>
        public int? ShadowOffsetX { set; get; }

        /// <summary>
        /// 阴影垂直方向上的偏移距离。
        /// <para>注意：此配置项生效的前提是，设置了 show: true。</para>
        /// </summary>
        public int? ShadowOffsetY { set; get; }

        /// <summary>
        /// 提示框组件。
        /// </summary>
        public Tooltip Tooltip { set; get; }
    }
}
