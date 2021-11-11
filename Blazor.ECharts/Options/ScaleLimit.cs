using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 滚轮缩放的极限控制，通过min, max最小和最大的缩放值，默认的缩放为1。
    /// </summary>
    public record ScaleLimit
    {
        /// <summary>
        /// 最小的缩放值
        /// </summary>
        public double Min { get; set; }
        /// <summary>
        /// 最大的缩放值
        /// </summary>
        public double Max { get; set; }
    }
}
