using Blazor.ECharts.Options.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record EChartsOption<T>
    {
        public EChartsBaseOption<T> BaseOption { get; set; }
        public List<EChartsOption<T>> Options { get; set; }
        /// <summary>
        /// 标题组件，可以存在任意多个标题组件，这在需要标题进行排版，或者单个实例中的多个图表都需要标题时会比较有用。
        /// </summary>
        public Title Title { set; get; }
        public Label Label { get; set; }
        /// <summary>
        /// 提示框组件。
        /// </summary>
        public Tooltip Tooltip { set; get; }

        /// <summary>
        /// 直角坐标系 grid 中的 x 轴，一般情况下单个 grid 组件最多只能放上下两个 x 轴，多于两个 x 轴需要通过配置 offset 属性防止同个位置多个 x 轴的重叠。
        /// </summary>
        public List<XAxis> XAxis { set; get; }

        /// <summary>
        /// 直角坐标系 grid 中的 y 轴，一般情况下单个 grid 组件最多只能放左右两个 y 轴，多于两个 y 轴需要通过配置 offset 属性防止同个位置多个 Y 轴的重叠。
        /// </summary>
        public List<YAxis> YAxis { set; get; }

        /// <summary>
        /// 系列列表。每个系列通过 type 决定自己的图表类型
        /// </summary>
        public List<object> Series { set; get; }

        /// <summary>
        /// 图例组件。
        /// </summary>
        public Legend Legend { set; get; }

        /// <summary>
        /// 工具栏。内置有导出图片，数据视图，动态类型切换，数据区域缩放，重置五个工具。
        /// </summary>
        public Toolbox Toolbox { set; get; }

        public DataSet DataSet { get; set; }

        /// <summary>
        /// 直角坐标系内绘图网格，单个 grid 内最多可以放置上下两个 X 轴，左右两个 Y 轴。可以在网格上绘制折线图，柱状图，散点图（气泡图）。
        /// </summary>
        public List<Grid> Grid { set; get; }

        /// <summary>
        /// dataZoom 组件 用于区域缩放，从而能自由关注细节的数据信息，或者概览数据整体，或者去除离群点的影响。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#dataZoom ">此处</see>查看详细设置</para>
        /// </summary>
        public List<object> DataZoom { set; get; }

        /// <summary>
        /// 调色盘颜色列表。如果系列没有设置颜色，则会依次循环从该列表中取颜色作为系列颜色。
        /// <para>默认为：['#c23531','#2f4554', '#61a0a8', '#d48265', '#91c7ae','#749f83',  '#ca8622', '#bda29a','#6e7074', '#546570', '#c4ccd3']</para>
        /// </summary>
        public IEnumerable<string> Color { set; get; }

        /// <summary>
        /// 背景色，默认无背景。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#backgroundColor ">此处</see>查看详细设置</para>
        /// </summary>
        public object BackgroundColor { set; get; }

        /// <summary>
        /// 全局的字体样式。
        /// </summary>
        public TextStyle TextStyle { set; get; }

        /// <summary>
        /// 是否开启动画。
        /// </summary>
        public bool? Animation { set; get; }

        /// <summary>
        /// 是否开启动画的阈值，当单个系列显示的图形数量大于这个阈值时会关闭动画。
        /// </summary>
        public int? AnimationThreshold { set; get; }

        /// <summary>
        /// 初始动画的时长，支持回调函数，可以通过每个数据返回不同的 delay 时间实现更戏剧的初始动画效果。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#animationDuration ">此处</see>查看详细设置</para>
        /// </summary>
        public object AnimationDuration { set; get; }

        /// <summary>
        /// 初始动画的缓动效果。不同的缓动效果可以参考 缓动示例 https://www.echartsjs.com/examples/en/editor.html?c=line-easing。
        /// </summary>
        public string AnimationEasing { set; get; }

        /// <summary>
        /// 初始动画的延迟，支持回调函数，可以通过每个数据返回不同的 delay 时间实现更戏剧的初始动画效果。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#animationDelay ">此处</see>查看详细设置</para>
        /// </summary>
        public object AnimationDelay { set; get; }

        /// <summary>
        /// 数据更新动画的时长。支持回调函数，可以通过每个数据返回不同的 delay 时间实现更戏剧的更新动画效果
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#animationDurationUpdate ">此处</see>查看详细设置</para>
        /// </summary>
        public object AnimationDurationUpdate { set; get; }

        /// <summary>
        /// 数据更新动画的缓动效果。
        /// </summary>
        public string AnimationEasingUpdate { set; get; }

        /// <summary>
        /// 数据更新动画的延迟，支持回调函数，可以通过每个数据返回不同的 delay 时间实现更戏剧的更新动画效果。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#animationDelayUpdate ">此处</see>查看详细设置</para>
        /// </summary>
        public object AnimationDelayUpdate { set; get; }

        /// <summary>
        /// 图形的混合模式，不同的混合模式见 https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/globalCompositeOperation 。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#blendMode ">此处</see>查看详细设置</para>
        /// </summary>
        public string BlendMode { set; get; }

        /// <summary>
        /// 图形数量阈值，决定是否开启单独的 hover 层，在整个图表的图形数量大于该阈值时开启单独的 hover 层。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#hoverLayerThreshold ">此处</see>查看详细设置</para>
        /// </summary>
        public int? HoverLayerThreshold { set; get; }

        /// <summary>
        /// 是否使用 UTC 时间。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#useUTC ">此处</see>查看详细设置</para>
        /// </summary>
        public bool? UseUTC { set; get; }

        /// <summary>
        /// 这是坐标轴指示器（axisPointer）的全局公用设置。
        /// </summary>
        public AxisPointer AxisPointer { set; get; }

        /// <summary>
        /// visualMap 是视觉映射组件，用于进行『视觉编码』，也就是将数据映射到视觉元素（视觉通道）。
        /// </summary>
        public object VisualMap { set; get; }

        /// <summary>
        /// graphic 是原生图形元素组件。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic">此处</see>查看详细设置</para>
        /// </summary>
        public List<object> Graphic { set; get; }

        public Polar Polar { set; get; }

        public RadiusAxis RadiusAxis { set; get; }

        /// <summary>
        /// 极坐标系的角度轴。
        /// </summary>
        public AngleAxis AngleAxis { set; get; }

        /// <summary>
        /// 雷达图坐标系组件，只适用于雷达图。
        /// </summary>
        public Radar Radar { set; get; }

        /// <summary>
        /// 区域选择组件，用户可以选择图中一部分数据，从而便于向用户展示被选中数据，或者他们的一些统计计算结果。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#brush">此处</see>查看详细设置</para>
        /// </summary>
        public Brush Brush { set; get; }
        public BMap Bmap { get; set; }
        public override string ToString()
        {
            JsonSerializerOptions jsonSerializerOptions = new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
            };
            return JsonSerializer.Serialize(this, jsonSerializerOptions);
        }
    }
}
