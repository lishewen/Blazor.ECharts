using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Sankey
{
    public record SankeyLink
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public int Value { get; set; }
    }
}
