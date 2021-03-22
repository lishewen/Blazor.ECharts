using Blazor.ECharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.WordCloud.Options
{
    public record WordCloudData
    {
        public string Name { get; set; }
        public int? Value { get; set; }
        public TextStyle TextStyle { get; set; }
    }
}
