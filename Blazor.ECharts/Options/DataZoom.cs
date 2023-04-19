using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record DataZoom
    {
        public DataZoom(string type)
        {
            Type = type;
        }
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// 设置 dataZoom-inside 组件控制的 x轴（即xAxis，是直角坐标系中的概念，参见 grid）。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.xAxisIndex ">此处</see>查看详细设置</para>
        /// </summary>
        public object XAxisIndex { set; get; }

        /// <summary>
        /// 设置 dataZoom-inside 组件控制的 y轴（即yAxis，是直角坐标系中的概念，参见 grid）。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.yAxisIndex ">此处</see>查看详细设置</para>
        /// </summary>
        public object YAxisIndex { set; get; }

        /// <summary>
        /// 设置 dataZoom-inside 组件控制的 radius 轴（即radiusAxis，是直角坐标系中的概念，参见 polar）。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.radiusAxisIndex ">此处</see>查看详细设置</para>
        /// </summary>
        public object RadiusAxisIndex { set; get; }

        /// <summary>
        /// 设置 dataZoom-inside 组件控制的 angle 轴（即angleAxis，是直角坐标系中的概念，参见 polar）。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.angleAxisIndex ">此处</see>查看详细设置</para>
        /// </summary>
        public object AngleAxisIndex { set; get; }

        /// <summary>
        /// dataZoom 的运行原理是通过 数据过滤 来达到 数据窗口缩放 的效果。数据过滤模式的设置不同，效果也不同。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.filterMode ">此处</see>查看详细设置</para>
        /// </summary>
        public FilterMode? FilterMode { set; get; }

        /// <summary>
        /// 数据窗口范围的起始百分比。范围是：0 ~ 100。表示 0% ~ 100%。
        /// </summary>
        public int? Start { set; get; }

        /// <summary>
        /// 数据窗口范围的结束百分比。范围是：0 ~ 100。表示 0% ~ 100%。
        /// </summary>
        public int? End { set; get; }

        /// <summary>
        /// 数据窗口范围的起始数值
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.startValue ">此处</see>查看详细设置</para>
        /// </summary>
        public object StartValue { set; get; }

        /// <summary>
        /// 数据窗口范围的结束数值
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.endValue ">此处</see>查看详细设置</para>
        /// </summary>
        public object EndValue { set; get; }

        /// <summary>
        /// 用于限制窗口大小的最小值（百分比值），取值范围是 0 ~ 100。
        /// </summary>
        public int? MinSpan { set; get; }

        /// <summary>
        /// 用于限制窗口大小的最大值（百分比值），取值范围是 0 ~ 100。
        /// </summary>
        public int? MaxSpan { set; get; }

        /// <summary>
        /// 用于限制窗口大小的最小值（实际数值）。
        /// </summary>
        /// <para>如在时间轴上可以设置为：3600 * 24 * 1000 * 5 表示 5 天。 在类目轴上可以设置为 5 表示 5 个类目。</para>
        public object MinValueSpan { set; get; }

        /// <summary>
        /// 用于限制窗口大小的最大值（实际数值）。
        /// </summary>
        /// <para>如在时间轴上可以设置为：3600 * 24 * 1000 * 5 表示 5 天。 在类目轴上可以设置为 5 表示 5 个类目。</para>
        public object MaxValueSpan { set; get; }

        /// <summary>
        /// 布局方式是横还是竖。不仅是布局方式，对于直角坐标系而言，也决定了，缺省情况控制横向数轴还是纵向数轴。
        /// </summary>
        public Orient? Orient { set; get; }

        /// <summary>
        /// 是否锁定选择区域（或叫做数据窗口）的大小。
        /// <para>如果设置为 true 则锁定选择区域的大小，也就是说，只能平移，不能缩放。</para>
        /// </summary>
        public bool? ZoomLock { set; get; }

        /// <summary>
        /// 设置触发视图刷新的频率。单位为毫秒（ms）。
        /// <para>如果 animation 设为 true 且 animationDurationUpdate 大于 0，可以保持 throttle 为默认值 100（或者设置为大于 0 的值），否则拖拽时有可能画面感觉卡顿。</para>
        /// <para>如果 animation 设为 false 或者 animationDurationUpdate 设为 0，且在数据量不大时，拖拽时画面感觉卡顿，可以把尝试把 throttle 设为 0 来改善。</para>
        /// </summary>
        public int? Throttle { set; get; }

        /// <summary>
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-inside.rangeMode ">此处</see>查看详细设置</para>
        /// </summary>
        public List<RangeMode> RangeMode { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 拖动时，是否实时更新系列的视图。如果设置为 false，则只在拖拽结束的时候更新。
        /// </summary>
        public bool? Realtime { set; get; }
    }
    public record DataZoomInside : DataZoom
    {
        public DataZoomInside() : base("inside") { }

        /// <summary>
        /// 是否停止组件的功能。
        /// </summary>
        public bool? Disabled { set; get; }

        /// <summary>
        /// 如何触发缩放。可选值为：
        /// <para>true：表示不按任何功能键，鼠标滚轮能触发缩放。</para>
        /// <para>false：表示鼠标滚轮不能触发缩放。</para>
        /// <para>'shift'：表示按住 shift 和鼠标滚轮能触发缩放。</para>
        /// <para>'ctrl'：表示按住 ctrl 和鼠标滚轮能触发缩放。</para>
        /// <para>'alt'：表示按住 alt 和鼠标滚轮能触发缩放。</para>
        /// </summary>
        public object ZoomOnMouseWheel { set; get; }

        /// <summary>
        /// 如何触发数据窗口平移。可选值为：
        /// <para>true：表示不按任何功能键，鼠标滚轮能触发缩放。</para>
        /// <para>false：表示鼠标滚轮不能触发缩放。</para>
        /// <para>'shift'：表示按住 shift 和鼠标滚轮能触发缩放。</para>
        /// <para>'ctrl'：表示按住 ctrl 和鼠标滚轮能触发缩放。</para>
        /// <para>'alt'：表示按住 alt 和鼠标滚轮能触发缩放。</para>
        /// </summary>
        public object MoveOnMouseMove { set; get; }

        /// <summary>
        /// 如何触发数据窗口平移。可选值为：
        /// <para>true：表示不按任何功能键，鼠标滚轮能触发缩放。</para>
        /// <para>false：表示鼠标滚轮不能触发缩放。</para>
        /// <para>'shift'：表示按住 shift 和鼠标滚轮能触发缩放。</para>
        /// <para>'ctrl'：表示按住 ctrl 和鼠标滚轮能触发缩放。</para>
        /// <para>'alt'：表示按住 alt 和鼠标滚轮能触发缩放。</para>
        /// </summary>
        public object MoveOnMouseWheel { set; get; }

        /// <summary>
        /// 是否阻止 mousemove 事件的默认行为。
        /// </summary>
        public bool? PreventDefaultMouseMove { set; get; }
    }
    public record DataZoomSlider : DataZoom
    {
        public DataZoomSlider() : base("slider") { }

        /// <summary>
        /// 组件的背景颜色。
        /// </summary>
        public string BackgroundColor { get; }

        /// <summary>
        /// 数据阴影的样式。
        /// </summary>
        public DataBackground DataBackground { set; get; }

        /// <summary>
        /// 选中范围的填充颜色。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.fillerColor ">此处</see>查看详细设置</para>
        /// </summary>
        public object FillerColor { set; get; }

        /// <summary>
        /// 边框颜色。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.borderColor ">此处</see>查看详细设置</para>
        /// </summary>
        public object BorderColor { set; get; }

        /// <summary>
        /// 手柄的 icon 形状，支持路径字符串。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.handleIcon ">此处</see>查看详细设置</para>
        /// </summary>
        public string HandleIcon { set; get; }

        /// <summary>
        /// 控制手柄的尺寸，可以是像素大小，也可以是相对于 dataZoom 组件宽度的百分比，默认跟 dataZoom 宽度相同。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.handleSize ">此处</see>查看详细设置</para>
        /// </summary>
        public object HandleSize { set; get; }

        /// <summary>
        /// 手柄的样式配置，见 示例 area-simple
        /// </summary>
        public HandleStyle HandleStyle { set; get; }

        /// <summary>
        /// 显示label的小数精度。默认根据数据自动决定。
        /// </summary>
        public int? LabelPrecision { set; get; }

        /// <summary>
        /// 显示的label的格式化器。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#dataZoom-slider.labelFormatter ">此处</see>查看详细设置</para>
        /// </summary>
        public object LabelFormatter { set; get; }

        /// <summary>
        /// 是否显示detail，即拖拽时候显示详细数值信息。
        /// </summary>
        public bool? ShowDetail { set; get; }

        /// <summary>
        /// 是否在 dataZoom-silder 组件中显示数据阴影。数据阴影可以简单地反应数据走势。
        /// </summary>
        public string ShowDataShadow { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public TextStyle TextStyle { set; get; }

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
        /// dataZoom-slider组件离容器左侧的距离。
        /// <para>left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。</para>
        /// <para>如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。</para>
        /// </summary>
        public object Left { set; get; }

        /// <summary>
        /// dataZoom-slider组件离容器上侧的距离。
        /// <para>top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。</para>
        /// <para>如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。</para>
        /// </summary>
        public object Top { set; get; }

        /// <summary>
        /// dataZoom-slider组件离容器右侧的距离。
        /// <para>right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。</para>
        /// </summary>
        public object Right { set; get; }

        /// <summary>
        /// dataZoom-slider组件离容器下侧的距离。
        /// <para>bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。</para>
        /// </summary>
        public object Bottom { set; get; }
    }
    public record DataBackground
    {
        /// <summary>
        /// 阴影的线条样式
        /// </summary>
        public LineStyle LineStyle { set; get; }

        /// <summary>
        /// 阴影的填充样式
        /// </summary>
        public AreaStyle AreaStyle { set; get; }
    }
}
