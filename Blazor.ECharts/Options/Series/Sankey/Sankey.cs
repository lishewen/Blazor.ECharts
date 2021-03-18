using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Sankey
{
    /// <summary>
    /// 桑基图
    /// </summary>
    public record Sankey : SeriesBase
    {
        public Sankey() : base("sankey") { }
        public List<SankeyLink> Links { get; set; }
    }
}
