using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public class Title
    {
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 是否显示标题组件。
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 主标题文本，支持使用 \n 换行。
        /// </summary>
        public string Text { set; get; }

        /// <summary>
        /// 主标题文本超链接。
        /// </summary>
        public string Link { set; get; }

        /// <summary>
        /// 指定窗口打开主标题超链接。
        /// </summary>
        public Target? Target { set; get; }

        /// <summary>
        /// 主标题文字样式
        /// </summary>
        public TextStyle TextStyle { set; get; }

        /// <summary>
        /// 副标题文本，支持使用 \n 换行。
        /// </summary>
        public string Subtext { set; get; }

        /// <summary>
        /// 副标题文本超链接。
        /// </summary>
        public string Sublink { set; get; }

        /// <summary>
        /// 指定窗口打开副标题超链接。
        /// </summary>
        public Target? Subtarget { set; get; }

        /// <summary>
        /// 副标题文字样式
        /// </summary>
        public TextStyle SubtextStyle { set; get; }

        /// <summary>
        /// 整体（包括 text 和 subtext）的水平对齐。
        /// </summary>
        public Align? TextAlign { set; get; }

        /// <summary>
        /// 整体（包括 text 和 subtext）的水平对齐。
        /// </summary>
        public Align? TextVerticalAlign { set; get; }

        /// <summary>
        /// 是否触发事件。
        /// </summary>
        public bool? TriggerEvent { set; get; }

        /// <summary>
        /// 标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距。
        /// <para>如：5、[5,10]、[5,10,5,10]</para>
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#title.padding ">此处</see>查看详细设置</para>
        /// </summary>
        public object Padding { set; get; }

        /// <summary>
        /// 主副标题之间的间距。
        /// </summary>
        public int? ItemGap { set; get; }

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
        /// 标题背景色，默认透明。
        /// <para>颜色可以使用 RGB 表示，比如 'rgb(128, 128, 128)' ，如果想要加上 alpha 通道，可以使用 RGBA，比如 'rgba(128, 128, 128, 0.5)'，也可以使用十六进制格式，比如 '#ccc'</para>
        /// </summary>
        public string BackgroundColor { set; get; }

        /// <summary>
        /// 标题的边框颜色。
        /// <para>颜色可以使用 RGB 表示，比如 'rgb(128, 128, 128)' ，如果想要加上 alpha 通道，可以使用 RGBA，比如 'rgba(128, 128, 128, 0.5)'，也可以使用十六进制格式，比如 '#ccc'</para>
        /// </summary>
        public string BorderColor { set; get; }

        /// <summary>
        /// 标题的边框线宽。
        /// </summary>
        public int? BorderWidth { set; get; }

        /// <summary>
        /// 圆角半径，单位px，支持传入数组分别指定 4 个圆角半径。 如:
        /// <para>5：统一设置四个角的圆角大小</para>
        /// <para>[5, 5, 0, 0]：顺时针左上，右上，右下，左下</para>
        /// </summary>
        public object BorderRadius { set; get; }

        /// <summary>
        /// 图形阴影的模糊大小。该属性配合 shadowColor,shadowOffsetX, shadowOffsetY 一起设置图形的阴影效果。
        /// <para>注意：此配置项生效的前提是，设置了 show: true 以及值不为 tranparent 的背景色 backgroundColor。</para>
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
        /// 文档中没有，示例中却有？？？
        /// </summary>
        public Align? X { set; get; }

        /// <summary>
        /// 文档中没有，示例中却有？？？
        /// </summary>
        public Align? Align { set; get; }
    }
}
