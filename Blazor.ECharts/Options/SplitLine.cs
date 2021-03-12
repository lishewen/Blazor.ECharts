using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 坐标轴在 grid 区域中的分隔线。
    /// </summary>
    public class SplitLine
    {
        /// <summary>
        /// 是否显示分隔线。默认数值轴显示，类目轴不显示。
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 坐标轴分隔线的显示间隔，在类目轴中有效。默认同 axisLabel.interval 一样。
        /// </summary>
        public object Interval { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public LineStyle LineStyle { set; get; }
    }
}
