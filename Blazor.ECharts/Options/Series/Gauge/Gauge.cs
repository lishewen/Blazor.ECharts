using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Gauge
{
    /// <summary>
    /// 仪表盘
    /// </summary>
    public record Gauge : SeriesBase
    {
        public Gauge() : base("gauge") { }
        public Detail Detail { get; set; }
    }
}
