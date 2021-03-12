using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public class TextStyle
    {
        /// <summary>
        /// 主标题文字的颜色。
        /// </summary>
        public string Color { set; get; }

        /// <summary>
        /// 文字块背景色。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#radar.name.backgroundColor">此处</see>查看详细设置</para>
        /// </summary>
        public object BackgroundColor { set; get; }

        /// <summary>
        /// 主标题文字字体的风格
        /// </summary>
        public FontStyle? FontStyle { set; get; }

        /// <summary>
        /// 主标题文字字体的粗细
        /// <para>使用  FontWeight 枚举或者数字，如100、200、300、400...</para>
        /// </summary>
        public object FontWeight { set; get; }

        /// <summary>
        /// 主标题文字的字体系列
        /// </summary>
        public string FontFamily { set; get; }

        /// <summary>
        /// 主标题文字的字体大小
        /// </summary>
        public int? FontSize { set; get; }

        /// <summary>
        /// 文字块的圆角。
        /// </summary>
        public object BorderRadius { set; get; }

        /// <summary>
        /// 文字块的内边距。
        /// </summary>
        public object Padding { set; get; }

        /// <summary>
        /// 行高。
        /// <para>rich 中如果没有设置 lineHeight，则会取父层级的 lineHeight</para>
        /// </summary>
        public int? LineHeight { set; get; }

        /// <summary>
        /// 文字块的宽度。一般不用指定，不指定则自动是文字的宽度。在想做表格项或者使用图片（参见 backgroundColor）时，可能会使用它。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#title.textStyle.width ">此处</see>查看详细设置</para>
        /// </summary>
        public object Width { set; get; }

        /// <summary>
        /// 文字块的高度。一般不用指定，不指定则自动是文字的高度。在使用图片（参见 backgroundColor）时，可能会使用它。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#title.textStyle.height ">此处</see>查看详细设置</para>
        /// </summary>
        public object Height { set; get; }

        /// <summary>
        /// 文字本身的描边颜色。
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
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#title.textStyle.rich ">此处</see>查看详细设置</para>
        /// </summary>
        public object Rich { set; get; }
    }
}
