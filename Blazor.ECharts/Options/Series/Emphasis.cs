using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    public record Emphasis
    {
        /// <summary>
        /// 
        /// </summary>
        public bool? Show { set; get; }
        public Label Label { set; get; }
        public TextStyle TextStyle { set; get; }
        public ItemStyle ItemStyle { set; get; }
    }
}
