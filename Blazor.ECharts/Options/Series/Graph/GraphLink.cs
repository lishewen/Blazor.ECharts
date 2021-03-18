using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Graph
{
    public record GraphLink
    {
        public int Source { get; set; }
        public int Target { get; set; }
        public string Value { get; set; }
    }
}
