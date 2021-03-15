using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record EChartsBaseOption<T> : EChartsOption<T>
    {
        public Timeline Timeline { get; set; }
    }
}
