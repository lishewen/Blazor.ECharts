using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Scatter
{
    /// <summary>
    /// 散点图
    /// </summary>
    public record Scatter : SeriesBase
    {
        public Scatter() : base("scatter") { }
    }
}
