using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Radar
{
    public record Radar : SeriesBase
    {
        public Radar() : base("radar") { }

        public LineStyle LineStyle { set; get; }

        public object Symbol { set; get; }

        public ItemStyle ItemStyle { set; get; }

        public AreaStyle AreaStyle { set; get; }
    }
}
