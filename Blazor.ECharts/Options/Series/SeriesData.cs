using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    public class SeriesData
    {
        public string Name { set; get; }
        public object Value { set; get; }
        public Tooltip Tooltip { set; get; }
        public ItemStyle ItemStyle { set; get; }
        public Label Label { set; get; }
    }
}
