using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record Effect
    {
        public int? ConstantSpeed { get; set; }
        public bool? Show { get; set; }
        public double? TrailLength { get; set; }
        public double? SymbolSize { get; set; }
    }
}
