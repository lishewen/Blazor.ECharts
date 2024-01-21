using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record DataSet
    {
        public string[] Dimensions { get; set; }
        public dynamic Source { get; set; }
        public Transform Transform { get; set; }
        public int? FromDatasetIndex { get; set; }
        public int? FromTransformResult { get; set; }
    }
}
