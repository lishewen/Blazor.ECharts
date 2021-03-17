using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    public record NoteDataItem
    {
        public string Name { get; set; }
        public int? Value { get; set; }
        public List<NoteDataItem> Children { get; set; }
    }
}
