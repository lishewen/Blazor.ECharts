using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// JS函数
    /// </summary>
    public record JFunc
    {
        public JFunc() { }
        public JFunc(string raw) => RAW = raw;
        public string RAW { get; set; }
    }
}
