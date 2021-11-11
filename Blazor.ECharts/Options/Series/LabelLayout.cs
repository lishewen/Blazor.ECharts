using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    /// <summary>
    /// 标签的统一布局配置。
    /// </summary>
    public record LabelLayout
    {
        /// <summary>
        /// 标签显示的文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 默认的标签的包围盒，由系列默认的标签布局决定
        /// </summary>
        public Rect LabelRect { get; set; }
        /// <summary>
        /// 默认的标签水平对齐
        /// </summary>
        public Align2 Align { get; set; }
        /// <summary>
        /// 默认的标签垂直对齐
        /// </summary>
        public VerticalAlign VerticalAlign { get; set; }
        /// <summary>
        /// 标签所对应的数据图形的包围盒，可用于定位标签位置
        /// </summary>
        public Rect Rect { get; set; }
        public object FontSize { get; set; }
        /// <summary>
        /// 是否隐藏重叠的标签。
        /// </summary>
        public bool? HideOverlap { get; set; }
        /// <summary>
        /// 在标签重叠的时候是否挪动标签位置以防止重叠。
        /// </summary>
        public MoveOverlap? MoveOverlap { get; set; }
    }
}
