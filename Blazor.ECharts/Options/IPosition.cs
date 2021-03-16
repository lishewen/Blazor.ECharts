using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public interface IPosition
    {
        public object Left { set; get; }
        public object Top { set; get; }
        public object Right { set; get; }
        public object Bottom { set; get; }
        public object Width { set; get; }
        public object Height { set; get; }
    }
}
