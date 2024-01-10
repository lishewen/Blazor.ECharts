using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Line
{
    /// <summary>
    /// 折线图
    /// </summary>
    public record Line : SeriesBase
    {
        public Line() : base("line") { }

        /// <summary>
        /// 该系列使用的坐标系
        /// </summary>
        public CoordinateSystem? CoordinateSystem { set; get; }

        /// <summary>
        /// 使用的 x 轴的 index，在单个图表实例中存在多个 x 轴的时候有用。
        /// </summary>
        public int? XAxisIndex { set; get; }

        /// <summary>
        /// 使用的 y 轴的 index，在单个图表实例中存在多个 y轴的时候有用。
        /// </summary>
        public int? YAxisIndex { set; get; }

        /// <summary>
        /// 使用的极坐标系的 index，在单个图表实例中存在多个极坐标系的时候有用。
        /// </summary>
        public int? PolarIndex { set; get; }

        /// <summary>
        /// 标记的图形
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.symbol ">此处</see>查看详细设置</para>
        /// </summary>
        public string Symbol { set; get; }

        /// <summary>
        /// 标记的大小
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.symbolSize ">此处</see>查看详细设置</para>
        /// </summary>
        public object SymbolSize { set; get; }

        /// <summary>
        /// 标记的旋转角度。注意在 markLine 中当 symbol 为 'arrow' 时会忽略 symbolRotate 强制设置为切线的角度。
        /// </summary>
        public int? SymbolRotate { set; get; }

        /// <summary>
        /// 如果 symbol 是 path:// 的形式，是否在缩放时保持该图形的长宽比。
        /// </summary>
        public bool? SymbolKeepAspect { set; get; }

        /// <summary>
        /// 标记相对于原本位置的偏移。默认情况下，标记会居中置放在数据对应的位置，但是如果 symbol 是自定义的矢量路径或者图片，就有可能不希望 symbol 居中。这时候可以使用该配置项配置 symbol 相对于原本居中的偏移，可以是绝对的像素值，也可以是相对的百分比。
        /// <para>例如[0, '50%'] 就是把自己向上移动了一半的位置，在 symbol 图形是气泡的时候可以让图形下端的箭头对准数据点。</para>
        /// </summary>
        public string SymbolOffset { set; get; }

        /// <summary>
        /// 是否显示 symbol, 如果 false 则只有在 tooltip hover 的时候显示。
        /// </summary>
        public bool? ShowSymbol { set; get; }

        /// <summary>
        /// 本系列特定的 tooltip 设定。
        /// </summary>
        public Tooltip Tooltip { set; get; }

        /// <summary>
        /// 只在主轴为类目轴（axis.type 为 'category'）时有效。 可选值：
        /// <para>'auto'：默认，如果有足够空间则显示标志图形，否则随主轴标签间隔隐藏策略。</para>
        /// <para>true：显示所有图形。</para>
        /// <para>false：随主轴标签间隔隐藏策略。</para>
        /// </summary>
        public bool? ShowAllSymbol { set; get; }

        /// <summary>
        /// 是否开启 hover 在拐点标志上的提示动画效果。
        /// </summary>
        public bool? HoverAnimation { set; get; }

        /// <summary>
        /// 是否启用图例 hover 时的联动高亮。
        /// </summary>
        public bool? LegendHoverLink { set; get; }

        /// <summary>
        /// 数据堆叠，同个类目轴上系列配置相同的stack值后，后一个系列的值会在前一个系列的值上相加。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.stack ">此处</see>查看详细设置</para>
        /// </summary>
        public string Stack { set; get; }

        /// <summary>
        /// 鼠标悬浮时在图形元素上时鼠标的样式是什么。同 CSS 的 cursor。
        /// </summary>
        public string Cursor { set; get; }

        /// <summary>
        /// 是否连接空数据。
        /// </summary>
        public bool? ConnectNulls { set; get; }

        /// <summary>
        /// 【从 4.4.0 开始支持】是否裁剪超出坐标系部分的图形，具体裁剪效果根据系列决定：
        /// <para>散点图：忽略中心点超出坐标系的图形，但是不裁剪单个图形</para>
        /// <para>柱状图：裁掉所有超出坐标系的部分，但是依然保留柱子的宽度</para>
        /// <para>折线图：裁掉所有超出坐标系的折线部分，拐点图形的逻辑按照散点图处理</para>
        /// <para>路径图：裁掉所有超出坐标系的部分</para>
        /// <para>自定义系列：裁掉所有超出坐标系的部分</para>
        /// <para>-- 除了自定义系列，其它系列的默认值都为 true，及开启裁剪，如果你觉得不想要裁剪的话，可以设置成 false 关闭。</para>
        /// </summary>
        public bool? Clip { set; get; }

        /// <summary>
        /// 是否是阶梯线图。可以设置为 true 显示成阶梯线图，也支持设置成 'start', 'middle', 'end' 分别配置在当前点，当前点与下个点的中间点，下个点拐弯。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.step ">此处</see>查看详细设置</para>
        /// </summary>
        public bool? Step { set; get; }

        /// <summary>
        /// 区域填充样式。
        /// </summary>
        public AreaStyle AreaStyle { set; get; }

        /// <summary>
        /// 线条样式。
        /// </summary>
        public LineStyle LineStyle { set; get; }

        /// <summary>
        /// 是否平滑曲线显示。
        /// <para>如果是 boolean 类型，则表示是否开启平滑处理。如果是 number 类型（取值范围 0 到 1），表示平滑程度，越小表示越接近折线段，反之则反。设为 true 时相当于设为 0.5。</para>
        /// <para>如果需要修改平滑算法，请参考 smoothMonotone。</para>
        /// </summary>
        public object Smooth { set; get; }

        /// <summary>
        /// 是否开启动画。
        /// </summary>
        public bool? Animation { set; get; }

        /// <summary>
        /// 图表标域，常用于标记图表中某个范围的数据，例如标出某段时间投放了广告。
        /// </summary>
        public MarkArea MarkArea { set; get; }

        /// <summary>
        /// 图表标注。
        /// </summary>
        public MarkPoint MarkPoint { set; get; }

        /// <summary>
        /// 折线图在数据量远大于像素点时候的降采样策略，开启后可以有效的优化图表的绘制效率，默认关闭，也就是全部绘制不过滤数据点。
        /// </summary>
        public Sampling? Sampling { set; get; }

        /// <summary>
        /// 折线拐点标志的样式。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#series-line.itemStyle">此处</see>查看详细设置</para>
        /// </summary>
        public ItemStyle ItemStyle { set; get; }

        /// <summary>
        /// 图表标线。
        /// </summary>
        public MarkLine MarkLine { set; get; }
        public Encode Encode { get; set; }
    }
}
