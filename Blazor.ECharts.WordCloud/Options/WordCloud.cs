using Blazor.ECharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.WordCloud.Options
{
    /// <summary>
    /// 词云图
    /// </summary>
    public record WordCloud : SeriesBase, IPosition
    {
        public WordCloud() : base("wordCloud") { }
        /// <summary>
        /// 词的间距
        /// </summary>
        public int? GridSize { get; set; }
        /// <summary>
        /// 词云形状，可选diamond，pentagon，circle，triangle，star等形状
        /// </summary>
        public Shape? Shape { get; set; }
        /// <summary>
        /// 词云大小范围
        /// </summary>
        public int[] SizeRange { get; set; }
        public object Left { get; set; }
        public object Top { get; set; }
        public object Right { get; set; }
        public object Bottom { get; set; }
        public object Width { get; set; }
        public object Height { get; set; }
        public TextStyle TextStyle { get; set; }
    }
}
