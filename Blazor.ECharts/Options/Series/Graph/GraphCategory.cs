using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Graph
{
    public record GraphCategory
    {
        public string Name { get; set; }
        public ItemStyle ItemStyle { get; set; }
    }
}
