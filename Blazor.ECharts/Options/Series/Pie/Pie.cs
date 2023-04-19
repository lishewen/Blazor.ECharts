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
        /// 饼图图形上的文本标签，可用于说明图形的一些数据信息，比如值，名称等，label选项在 ECharts 2.x 中放置于itemStyle下，在 ECharts 3 中为了让整个配置项结构更扁平合理，label 被拿出来跟 itemStyle 平级，并且跟 itemStyle 一样拥有 emphasis 状态。
        /// </summary>
        public Label Label { set; get; }

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
    }
}
