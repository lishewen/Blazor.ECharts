using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Tree
{
    /// <summary>
    /// 树图
    /// </summary>
    public record Tree : SeriesBase, IPosition
    {
        public Tree() : base("tree") { }

        public object Left { get; set; }
        public object Top { get; set; }
        public object Right { get; set; }
        public object Bottom { get; set; }
        public object Width { get; set; }
        public object Height { get; set; }
        public object SymbolSize { set; get; }
        public Leaves Leaves { get; set; }
    }
}
