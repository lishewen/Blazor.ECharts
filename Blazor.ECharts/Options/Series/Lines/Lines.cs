using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Lines
{
    /// <summary>
    /// 路径图
    /// </summary>
    public record Lines : SeriesBase
    {
        public Lines() : base("lines") { }
        /// <summary>
        /// 该系列使用的坐标系
        /// </summary>
        public CoordinateSystem? CoordinateSystem { set; get; }
        /// <summary>
        /// 是否是多段线。
        /// 默认为 false，只能用于绘制只有两个端点的线段，线段可以通过 lineStyle.curveness 配置为曲线。
        /// 如果该配置项为 true，则可以在 data.coords 中设置多于 2 个的顶点用来绘制多段线，在绘制路线轨迹的时候比较有用，见示例 北京公交路线，设置为多段线后 lineStyle.curveness 无效。
        /// </summary>
        public bool? Polyline { get; set; }
        public bool? Silent { set; get; }
        public LineStyle LineStyle { get; set; }
        /// <summary>
        /// 启用渐进式渲染的图形数量阈值，在单个系列的图形数量超过该阈值时启用渐进式渲染。
        /// </summary>
        public int? ProgressiveThreshold { get; set; }
        /// <summary>
        /// 渐进式渲染时每一帧绘制图形数量，设为 0 时不启用渐进式渲染，支持每个系列单独配置。
        /// 在图中有数千到几千万图形元素的时候，一下子把图形绘制出来，或者交互重绘的时候可能会造成界面的卡顿甚至假死。ECharts 4 开始全流程支持渐进渲染（progressive rendering），渲染的时候会把创建好的图形分到数帧中渲染，每一帧渲染只渲染指定数量的图形。
        /// 该配置项就是用于配置该系列每一帧渲染的图形数，可以根据图表图形复杂度的需要适当调整这个数字使得在不影响交互流畅性的前提下达到绘制速度的最大化。比如在 lines 图或者平行坐标中线宽大于 1 的 polyline 绘制会很慢，这个数字就可以设置小一点，而线宽小于等于 1 的 polyline 绘制非常快，该配置项就可以相对调得比较大。
        /// </summary>
        public int? Progressive { get; set; }
        public Effect Effect { get; set; }
        /// <summary>
        /// 所有图形的 zlevel 值。
        /// <para>zlevel用于 Canvas 分层，不同zlevel值的图形会放置在不同的 Canvas 中，Canvas 分层是一种常见的优化手段。我们可以把一些图形变化频繁（例如有动画）的组件设置成一个单独的zlevel。需要注意的是过多的 Canvas 会引起内存开销的增大，在手机端上需要谨慎使用以防崩溃。</para>
        /// <para>zlevel 大的 Canvas 会放在 zlevel 小的 Canvas 的上面。</para>
        /// </summary>
        public int? Zlevel { set; get; }
    }
}
