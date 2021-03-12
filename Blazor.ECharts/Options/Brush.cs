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
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#brush.xAxisIndex">此处</see>查看详细设置</para>
        /// </summary>
        public object XAxisIndex { set; get; }

        /// <summary>
        /// 不同系列间，选中的项可以联动。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#brush.brushLink">此处</see>查看详细设置</para>
        /// </summary>
        public object BrushLink { set; get; }

        /// <summary>
        /// 定义 在选中范围外 的视觉元素。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#brush.outOfBrush">此处</see>查看详细设置</para>
        /// </summary>
        public object OutOfBrush { set; get; }
    }
}
