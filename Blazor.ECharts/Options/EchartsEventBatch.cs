using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 对外通知当前选中了什么。
    /// </summary>
    public record EchartsEventBatch
    {
        public string BrushId { get; set; }
        public int BrushIndex { get; set; }
        public string BrushName { get; set; }
        public Area[] Areas { get; set; }
        public Selected[] Selected { get; set; }
        public string Type { get; set; }
    }

    public record Area
    {
        public string BrushType { get; set; }
        public string BrushMode { get; set; }
        public bool? Transformable { get; set; }
        public Brushstyle BrushStyle { get; set; }
        public bool? RemoveOnClick { get; set; }
        public int? Z { get; set; }
        public string PanelId { get; set; }
        public double[] Range { get; set; }
        public double[][] CoordRanges { get; set; }
        public object[] CoordRange { get; set; }
        public int? XAxisIndex { get; set; }
    }

    public record Brushstyle
    {
        public string Fill { get; set; }
        public string Stroke { get; set; }
        public int LineWidth { get; set; }
    }

    public class Selected
    {
        public string SeriesId { get; set; }
        public int SeriesIndex { get; set; }
        public string SeriesName { get; set; }
        public int[] DataIndex { get; set; }
    }

}
