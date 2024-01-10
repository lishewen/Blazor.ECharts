using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record Radar
    {
        /// <summary>
        /// 雷达图每个指示器名称的配置项。
        /// </summary>
        public RadarName Name { set; get; }

        /// <summary>
        /// 雷达图的指示器，用来指定雷达图中的多个变量（维度）
        /// </summary>
        public List<RadarIndicator> Indicator { set; get; }

        /// <summary>
        /// 雷达图绘制类型
        /// </summary>
        public RadarShape? Shape { set; get; }

        /// <summary>
        /// 指示器轴的分割段数。
        /// </summary>
        public int? SplitNumber { set; get; }

        /// <summary>
        /// 坐标轴在 grid 区域中的分隔线。
        /// </summary>
        public SplitLine SplitLine { set; get; }

        /// <summary>
        /// 坐标轴在 grid 区域中的分隔区域，默认不显示。
        /// </summary>
        public SplitArea SplitArea { set; get; }

        /// <summary>
        /// 坐标轴轴线相关设置。
        /// </summary>
        public AxisLine AxisLine { set; get; }

        public List<string> Center { get; set; }

        public int? Radius { get; set; }

    }
    /// <summary>
    /// 雷达图每个指示器名称的配置项。
    /// </summary>
    public record RadarName
    {
        public TextStyle TextStyle { set; get; }
    }
    public record RadarIndicator
    {
        /// <summary>
        /// 指示器名称。
        /// </summary>
        public string Name { set; get; }

        public string Text { set; get; }

        /// <summary>
        /// 指示器的最大值，可选，建议设置
        /// </summary>
        public int? Max { set; get; }

        /// <summary>
        /// 指示器的最小值，可选，默认为 0。
        /// </summary>
        public int? Min { set; get; }

        /// <summary>
        /// 标签特定的颜色。
        /// </summary>
        public string Color { set; get; }
    }
}
