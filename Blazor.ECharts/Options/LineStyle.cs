using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record LineStyle : AreaStyle
    {
        /// <summary>
        /// 线宽。
        /// </summary>
        public double? Width { set; get; }

        /// <summary>
        /// 线的类型。
        /// </summary>
        public LineStyleType? Type { set; get; }
        /// <summary>
        /// 关系连接线的弯曲程度
        /// </summary>
        public int? Curveness { get; set; }
    }
}
