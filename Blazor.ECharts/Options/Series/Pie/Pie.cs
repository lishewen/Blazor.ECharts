using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Pie
{
    /// <summary>
    /// 饼图
    /// </summary>
    public record Pie : SeriesBase
    {
        public Pie() : base("pie") { }

        /// <summary>
        /// 饼图的半径。可以为如下类型：
        /// <para>number：直接指定外半径值。</para>
        /// <para>string：例如，'20%'，表示外半径为可视区尺寸（容器高宽中较小一项）的 20% 长度。</para>
        /// <para>Array：数组的第一项是内半径，第二项是外半径。每一项遵从上述 number string 的描述。</para>
        /// </summary>
        public object Radius { set; get; }

        /// <summary>
        /// 是否启用防止标签重叠策略，默认开启，在标签拥挤重叠的情况下会挪动各个标签的位置，防止标签间的重叠。
        /// <para>如果不需要开启该策略，例如<see href="https://echarts.apache.org/examples/en/editor.html?c=pie-doughnut">圆环图</see>这个例子中需要强制所有标签放在中心位置，可以将该值设为 false。</para>
        /// </summary>
        public bool? AvoidLabelOverlap { set; get; }

        /// <summary>
        /// 标签的视觉引导线样式，在 label 位置 设置为'outside'的时候会显示视觉引导线。
        /// </summary>
        public LabelLine LabelLine { set; get; }

        public object Center { set; get; }

        /// <summary>
        /// 高亮的扇区和标签样式
        /// </summary>
        public Emphasis Emphasis { set; get; }

        /// <summary>
        /// 选中模式，表示是否支持多个选中，默认关闭，支持布尔值和字符串，字符串取值可选'single'，'multiple'，分别表示单选还是多选。
        /// <para>可使用枚举值 SelectedMode</para>
        /// </summary>
        public object SelectedMode { set; get; }

        /// <summary>
        /// 选中扇区的偏移距离。
        /// </summary>
        public int? SelectedOffset { set; get; }

        /// <summary>
        /// 饼图的扇区是否是顺时针排布。
        /// </summary>
        public bool? Clockwise { set; get; }

        /// <summary>
        /// 起始角度，支持范围[0, 360]。
        /// </summary>
        public int? StartAngle { get; set; }

        /// <summary>
        /// 结束角度，默认值是 'auto'。
        /// 当值为 'auto' 时，根据 startAngle 自动计算结束角度，以确保是一个完整的圆。
        /// </summary>
        public object EndAngle { get; set; }

        /// <summary>
        /// 最小的扇区角度（0 ~ 360），用于防止某个值过小导致扇区太小影响交互。
        /// </summary>
        public int? MinAngle { get; set; }

        /// <summary>
        /// 饼图扇区之间的间隔角度（0 ~ 360）。
        /// </summary>
        public int? PadAngle { get; set; }

        /// <summary>
        /// 小于这个角度（0 ~ 360）的扇区，不显示标签（label 和 labelLine）。
        /// </summary>
        public int? MinShowLabelAngle { get; set; }
    }
}
