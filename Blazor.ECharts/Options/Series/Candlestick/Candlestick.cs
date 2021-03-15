using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Candlestick
{
    /// <summary>
    /// K线图
    /// </summary>
    public record Candlestick : SeriesBase
    {
        public Candlestick() : base("candlestick") { }

        public ItemStyle ItemStyle { set; get; }

        public Tooltip Tooltip { set; get; }

        public MarkLine MarkLine { set; get; }

        public MarkPoint MarkPoint { set; get; }
    }
}
