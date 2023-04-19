using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record DispatchActionOption
    {
        public string Type { get; set; }
        public int? SeriesIndex { get; set; }
        public int? DataIndex { get; set; }
        public List<Area> Areas { get; set; }

        /// <summary>
        /// 转化为JSON字符串
        /// </summary>
        /// <returns>JSON字符串</returns>
        public override string ToString()
        {
            return EChartsOptionSerializer.Default.Serialize(this);
        }
    }
}
