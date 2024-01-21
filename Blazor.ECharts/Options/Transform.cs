using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record Transform
    {
        public string Type { get; set; }
        public TransformConfig Config { get; set; }
    }
    public record TransformConfig
    {
        public object ItemNameFormatter { get; set; }
    }
}
