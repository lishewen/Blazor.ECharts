using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Sunburst
{
    public record SunburstData
    {
        public string Name { get; set; }
        public List<SunburstDataChildren> Children { get; set; }
    }

    public record SunburstDataChildren
    {
        public string Name { get; set; }
        public int? Value { get; set; }
        public List<SunburstDataChildren> Children { get; set; }
    }
}
