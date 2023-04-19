using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public class Brush
    {
        /// <summary>
        /// 指定哪些 xAxisIndex 可以被刷选。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#brush.xAxisIndex">此处</see>查看详细设置</para>
        /// </summary>
        public object XAxisIndex { set; get; }

        /// <summary>
        /// 指定哪些 series 可以被刷选，可取值为：
        //'all': 所有 series
        //'Array': series index 列表
        //'number': 某个 series index
        /// </summary>
        public object SeriesIndex { set; get; }

        /// <summary>
        /// 默认的刷子类型。
        //'rect'：矩形选框。
        //'polygon'：任意形状选框。
        //'lineX'：横向选择。
        //'lineY'：纵向选择。
        /// </summary>
        public string BrushType { set; get; }

        /// <summary>
        // 默认的刷子的模式。可取值为：
        // 'single'：单选。
        // 'multiple'：多选。
        /// </summary>
        public string BrushMode { set; get; }

        /// <summary>
        /// 不同系列间，选中的项可以联动。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#brush.brushLink">此处</see>查看详细设置</para>
        /// </summary>
        public object BrushLink { set; get; }

        /// <summary>
        /// 定义 在选中范围外 的视觉元素。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#brush.outOfBrush">此处</see>查看详细设置</para>
        /// </summary>
        public object OutOfBrush { set; get; }

        /// <summary>
        /// 默认情况，刷选或者移动选区的时候，会不断得发 brushSelected 事件，从而告诉外界选中的内容。
        /// 但是频繁的事件可能导致性能问题，或者动画效果很差。所以 brush 组件提供了 brush.throttleType，brush.throttleDelay 来解决这个问题。
        /// throttleType 取值可以是：
        /// 'debounce'：表示只有停止动作了（即一段时间没有操作了），才会触发事件。时间阈值由 brush.throttleDelay 指定。
        /// 'fixRate'：表示按照一定的频率触发事件，时间间隔由 brush.throttleDelay 指定。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#brush.throttleType">此处</see>查看详细设置</para>
        /// </summary>
        public string ThrottleType { get; set; }

        /// <summary>
        /// 默认为 0 表示不开启 throttle。
        /// 默认情况，刷选或者移动选区的时候，会不断得发 brushSelected 事件，从而告诉外界选中的内容。
        /// 但是频繁的事件可能导致性能问题，或者动画效果很差。所以 brush 组件提供了 brush.throttleType，brush.throttleDelay 来解决这个问题。
        /// throttleType 取值可以是：
        /// 'debounce'：表示只有停止动作了（即一段时间没有操作了），才会触发事件。时间阈值由 brush.throttleDelay 指定。
        /// 'fixRate'：表示按照一定的频率触发事件，时间间隔由 brush.throttleDelay 指定。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#brush.throttleDelay">此处</see>查看详细设置</para>
        /// </summary>
        public int ThrottleDelay { get;set; }
    }
}
