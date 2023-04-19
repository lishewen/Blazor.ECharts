using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 图例组件。
    /// </summary>
    public class Legend
    {
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 图例的类型
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.type ">此处</see>查看详细设置</para>
        /// </summary>
        public LegendType? Type { set; get; }

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
        public int? Width { set; get; }

        /// <summary>
        /// 图例组件的高度。默认自适应。
        /// </summary>
        public int? Height { set; get; }

        /// <summary>
        /// 图例列表的布局朝向。
        /// </summary>
        public Orient? Orient { set; get; }

        /// <summary>
        /// 图例标记和文本的对齐。默认自动，根据组件的位置和 orient 决定，当组件的 left 值为 'right' 以及纵向布局（orient 为 'vertical'）的时候为右对齐，即为 'right'。
        /// </summary>
        public Align1? Align { set; get; }

        /// <summary>
        /// 图例内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距。如：
        /// <para>5：设置内边距为 5</para>
        /// <para>[5, 10]：设置上下的内边距为 5，左右的内边距为 10</para>
        /// <para>[5, 5, 0, 0]：分别设置四个方向的内边距</para>
        /// </summary>
        public object Padding { set; get; }

        /// <summary>
        /// 图例每项之间的间隔。横向布局时为水平间隔，纵向布局时为纵向间隔。
        /// </summary>
        public int? ItemGap { set; get; }

        /// <summary>
        /// 图例标记的图形宽度。
        /// </summary>
        public int? ItemWidth { set; get; }

        /// <summary>
        /// 图例标记的图形高度。
        /// </summary>
        public int? ItemHeight { set; get; }

        /// <summary>
        /// 如果图标（可能来自系列的 symbol 或用户自定义的 legend.data.icon）是 path:// 的形式，是否在缩放时保持该图形的长宽比。
        /// </summary>
        public bool? SymbolKeepAspect { set; get; }

        /// <summary>
        /// 用来格式化图例文本，支持字符串模板和回调函数两种形式。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.formatter ">此处</see>查看详细设置</para>
        /// </summary>
        public object Formatter { set; get; }

        /// <summary>
        /// 图例选择的模式，控制是否可以通过点击图例改变系列的显示状态。默认开启图例选择，可以设成 false 关闭。
        /// <para>除此之外也可以设成 'single' 或者 'multiple' 使用单选或者多选模式。</para>
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selectedMode ">此处</see>查看详细设置</para>
        /// </summary>
        public object SelectedMode { set; get; }

        /// <summary>
        /// 图例关闭时的颜色。
        /// </summary>
        public string InactiveColor { set; get; }

        /// <summary>
        /// 图例选中状态表。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selected ">此处</see>查看详细设置</para>
        /// </summary>
        public object Selected { set; get; }

        /// <summary>
        /// 图例的公用文本样式。
        /// </summary>
        public TextStyle TextStyle { set; get; }

        /// <summary>
        /// 图例的 tooltip 配置，配置项同 tooltip。默认不显示，可以在 legend 文字很多的时候对文字做裁剪并且开启 tooltip。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.tooltip ">此处</see>查看详细设置</para>
        /// </summary>
        public Tooltip Tooltip { set; get; }

        /// <summary>
        /// 图例项的 icon。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.icon ">此处</see>查看详细设置</para>
        /// </summary>
        public string Icon { set; get; }

        /// <summary>
        /// 文档中没有，实例中有？？？
        /// </summary>
        public Align? X { set; get; }

        /// <summary>
        /// 图例的数据数组
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.data ">此处</see>查看详细设置</para>
        /// </summary>
        public object Data { set; get; }

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
        /// 圆角半径，单位px，支持传入数组分别指定 4 个圆角半径。 如:
        /// <para>5：统一设置四个角的圆角大小</para>
        /// <para>[5, 5, 0, 0]：顺时针左上，右上，右下，左下</para>
        /// </summary>
        public object BorderRadius { set; get; }

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
        /// legend.type 为 'scroll' 时有效。图例当前最左上显示项的 dataIndex。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.scrollDataIndex ">此处</see>查看详细设置</para>
        /// </summary>
        public int? ScrollDataIndex { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。图例控制块中，按钮和页信息之间的间隔。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageButtonItemGap ">此处</see>查看详细设置</para>
        /// </summary>
        public int? PageButtonItemGap { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。图例控制块和图例项之间的间隔。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageButtonGap ">此处</see>查看详细设置</para>
        /// </summary>
        public int? PageButtonGap { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。图例控制块的位置。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageButtonPosition ">此处</see>查看详细设置</para>
        /// </summary>
        public PositionY? PageButtonPosition { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。图例控制块中，页信息的显示格式。默认为 '{current}/{total}'，其中 {current} 是当前页号（从 1 开始计数），{total} 是总页数。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageFormatter ">此处</see>查看详细设置</para>
        /// </summary>
        public object PageFormatter { set; get; }

        /// <summary>
        /// 图例控制块的图标。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageIcons ">此处</see>查看详细设置</para>
        /// </summary>
        public PageIcons PageIcons { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。翻页按钮的颜色。
        /// </summary>
        public string PageIconColor { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。翻页按钮不激活时（即翻页到头时）的颜色。
        /// </summary>
        public string PageIconInactiveColor { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。翻页按钮的大小。可以是数字，也可以是数组，如 [10, 3]，表示 [宽，高]。
        /// </summary>
        public object PageIconSize { set; get; }

        /// <summary>
        /// legend.type 为 'scroll' 时有效。图例页信息的文字样式。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageTextStyle">此处</see>查看详细设置</para>
        /// </summary>
        public TextStyle PageTextStyle { set; get; }

        /// <summary>
        /// 图例翻页是否使用动画。
        /// </summary>
        public bool? Animation { set; get; }

        /// <summary>
        /// 图例翻页时的动画时长。
        /// </summary>
        public int? AnimationDurationUpdate { set; get; }

        /// <summary>
        /// 图例组件中的选择器按钮，目前包括全选和反选两种功能。默认不显示，用户可手动开启，也可以手动配置每个按钮的标题。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selector ">此处</see>查看详细设置</para>
        /// </summary>
        public object Selector { set; get; }

        /// <summary>
        /// 选择器按钮的文本标签样式，默认显示。
        /// </summary>
        public SelectorLabel SelectorLabel { set; get; }

        /// <summary>
        /// 选择器的位置，可以放在图例的尾部或者头部，对应的值分别为 'end' 和 'start'。默认情况下，图例横向布局的时候，选择器放在图例的尾部；图例纵向布局的时候，选择器放在图例的头部。
        /// </summary>
        public SelectorPosition? SelectorPosition { set; get; }

        /// <summary>
        /// 选择器按钮之间的间隔。
        /// </summary>
        public int? SelectorItemGap { set; get; }

        /// <summary>
        /// 选择器按钮与图例组件之间的间隔。
        /// </summary>
        public int? SelectorButtonGap { set; get; }
    }

    public class SelectorLabel
    {
        /// <summary>
        /// 是否显示标签。
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 距离图形元素的距离。当 position 为字符描述值（如 'top'、'insideRight'）时候有效。
        /// </summary>
        public int? Distance { set; get; }

        /// <summary>
        /// 标签旋转。从 -90 度到 90 度。正值是逆时针。
        /// </summary>
        public int? Rotate { set; get; }

        /// <summary>
        /// 是否对文字进行偏移。默认不偏移。例如：[30, 40] 表示文字在横向上偏移 30，纵向上偏移 40。
        /// </summary>
        public List<int> Offset { set; get; }

        /// <summary>
        /// 文字的颜色。
        /// <para>如果设置为 'auto'，则为视觉映射得到的颜色，如系列色。</para>
        /// </summary>
        public object Color { set; get; }

        /// <summary>
        /// 文字字体的风格
        /// </summary>
        public FontStyle? FontStyle { set; get; }

        /// <summary>
        /// 文字字体的粗细
        /// </summary>
        public FontWeight? FontWeight { set; get; }

        /// <summary>
        /// 文字的字体系列
        /// </summary>
        public string FontFamily { set; get; }

        /// <summary>
        /// 文字的字体大小
        /// </summary>
        public int? FontSize { set; get; }

        /// <summary>
        /// 文字水平对齐方式，默认自动。
        /// </summary>
        public Align2? Align { set; get; }

        /// <summary>
        /// 文字垂直对齐方式，默认自动。
        /// </summary>
        public VerticalAlign? VerticalAlign { set; get; }

        /// <summary>
        /// 行高。
        /// </summary>
        public int? LineHeight { set; get; }

        /// <summary>
        /// 文字块背景色。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selectorLabel.backgroundColor ">此处</see>查看详细设置</para>
        /// </summary>
        public object BackgroundColor { set; get; }

        /// <summary>
        /// 文字块边框颜色。如果设置为 'auto'，则为视觉映射得到的颜色，如系列色。
        /// </summary>
        public string BorderColor { set; get; }

        /// <summary>
        /// 文字块边框宽度。
        /// </summary>
        public int? BorderWidth { set; get; }

        /// <summary>
        /// 圆角半径，单位px，支持传入数组分别指定 4 个圆角半径。 如:
        /// <para>5：统一设置四个角的圆角大小</para>
        /// <para>[5, 5, 0, 0]：顺时针左上，右上，右下，左下</para>
        /// </summary>
        public object BorderRadius { set; get; }

        /// <summary>
        /// 图例内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距。如：
        /// <para>5：设置内边距为 5</para>
        /// <para>[5, 10]：设置上下的内边距为 5，左右的内边距为 10</para>
        /// <para>[5, 5, 0, 0]：分别设置四个方向的内边距</para>
        /// </summary>
        public object Padding { set; get; }

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
        /// 文字块的宽度。一般不用指定，不指定则自动是文字的宽度。在想做表格项或者使用图片（参见 backgroundColor）时，可能会使用它。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selectorLabel.width ">此处</see>查看详细设置</para>
        /// </summary>
        public object Width { set; get; }

        /// <summary>
        /// 文字块的高度。一般不用指定，不指定则自动是文字的宽度。在想做表格项或者使用图片（参见 backgroundColor）时，可能会使用它。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selectorLabel.height ">此处</see>查看详细设置</para>
        /// </summary>
        public object Height { set; get; }

        /// <summary>
        /// 文字本身的描边颜色。如果设置为 'auto'，则为视觉映射得到的颜色，如系列色。
        /// </summary>
        public string TextBorderColor { set; get; }

        /// <summary>
        /// 文字本身的描边宽度。
        /// </summary>
        public int? TextBorderWidth { set; get; }

        /// <summary>
        /// 文字本身的阴影颜色。
        /// </summary>
        public string TextShadowColor { set; get; }

        /// <summary>
        /// 文字本身的阴影长度。
        /// </summary>
        public int? TextShadowBlur { set; get; }

        /// <summary>
        /// 文字本身的阴影 X 偏移。
        /// </summary>
        public int? TextShadowOffsetX { set; get; }

        /// <summary>
        /// 文字本身的阴影 Y 偏移。
        /// </summary>
        public int? TextShadowOffsetY { set; get; }

        /// <summary>
        /// 在 rich 里面，可以自定义富文本样式。利用富文本样式，可以在标签中做出非常丰富的效果。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.selectorLabel.rich ">此处</see>查看详细设置</para>
        /// </summary>
        public object Rich { set; get; }
    }

    public class PageIcons
    {
        /// <summary>
        /// legend.orient 为 'horizontal' 时的翻页按钮图标。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageIcons.horizontal ">此处</see>查看详细设置</para>
        /// </summary>
        public List<string> Horizontal { set; get; }

        /// <summary>
        /// legend.orient 为 'vertical' 时的翻页按钮图标。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.pageIcons.vertical ">此处</see>查看详细设置</para>
        /// </summary>
        public List<string> Vertical { set; get; }
    }

    /// <summary>
    /// 图例的数据数组
    /// </summary>
    public class LegendData
    {
        /// <summary>
        /// 图例项的名称，应等于某系列的name值（如果是饼图，也可以是饼图单个数据的 name）。
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 图例项的 icon。可以通过 'image://url' 设置为图片，其中 URL 为图片的链接，或者 dataURI。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#legend.data.icon ">此处</see>查看详细设置</para>
        /// </summary>
        public string Icon { set; get; }

        /// <summary>
        /// 图例项的文本样式。
        /// </summary>
        public object TextStyle { set; get; }
    }
}
