using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    public class Label
    {
        /// <summary>
        /// 
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 标签的位置。
        /// </summary>
        public PieLabelPosition? Position { set; get; }

        /// <summary>
        /// 高亮的扇区和标签样式。
        /// </summary>
        public Emphasis Emphasis { set; get; }

        public object Formatter { set; get; }

        /// <summary>
        /// 文字块背景色。
        /// <para>可以是直接的颜色值，例如：'#123234', 'red', 'rgba(0,23,11,0.3)'。</para>
        /// <para>可以支持使用图片</para>
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-pie.data.label.backgroundColor">此处</see>查看详细设置</para>
        /// </summary>
        public object BackgroundColor { set; get; }

        /// <summary>
        /// 文字块边框颜色。
        /// </summary>
        public string BorderColor { set; get; }

        /// <summary>
        /// 文字块边框宽度。
        /// </summary>
        public double? BorderWidth { set; get; }

        /// <summary>
        /// 文字块的圆角。
        /// </summary>
        public object BorderRadius { set; get; }

        /// <summary>
        /// 在 rich 里面，可以自定义富文本样式。利用富文本样式，可以在标签中做出非常丰富的效果。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-pie.data.label.rich">此处</see>查看详细设置</para>
        /// </summary>
        public object Rich { set; get; }

        /// <summary>
        /// 文字水平对齐方式，默认自动。
        /// </summary>
        public Align2 Align { set; get; }

        /// <summary>
        /// 文字的颜色。
        /// </summary>
        public object Color { set; get; }

        /// <summary>
        /// 文字块的宽度。一般不用指定，不指定则自动是文字的宽度。在想做表格项或者使用图片（参见 backgroundColor）时，可能会使用它。
        /// <para>注意，如果不定义 rich 属性，则不能指定 width 和 height。</para>
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-pie.data.label.width">此处</see>查看详细设置</para>
        /// </summary>
        public object Width { set; get; }

        /// <summary>
        /// 文字块的高度。一般不用指定，不指定则自动是文字的高度。在使用图片（参见 backgroundColor）时，可能会使用它。
        /// <para>注意，如果不定义 rich 属性，则不能指定 width 和 height。</para>
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-pie.data.label.height">此处</see>查看详细设置</para>
        /// </summary>
        public object Height { set; get; }

        /// <summary>
        /// 文字块的内边距。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-pie.data.label.padding">此处</see>查看详细设置</para>
        /// </summary>
        public object Padding { set; get; }
    }
}
