using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 加载动画配置项
    /// https://echarts.apache.org/zh/api.html#echartsInstance.showLoading
    /// </summary>
    public record LoadingOption
    {
        public string Text { get; set; } = "loading";
        public string Color { get; set; } = "#c23531";
        public string TextColor { get; set; } = "#000";
        public string MaskColor { get; set; } = "rgba(255, 255, 255, 0.8)";
        public int Zlevel { get; set; } = 0;
        /// <summary>
        /// 字体大小。从 `v4.8.0` 开始支持。
        /// </summary>
        public int FontSize { get; set; } = 12;
        /// <summary>
        /// 是否显示旋转动画（spinner）。从 `v4.8.0` 开始支持。
        /// </summary>
        public bool ShowSpinner { get; set; } = true;
        /// <summary>
        /// 旋转动画（spinner）的半径。从 `v4.8.0` 开始支持。
        /// </summary>
        public int SpinnerRadius { get; set; } = 10;
        /// <summary>
        /// 旋转动画（spinner）的线宽。从 `v4.8.0` 开始支持。
        /// </summary>
        public int LineWidth { get; set; } = 5;
        /// <summary>
        /// 字体粗细。从 `v5.0.1` 开始支持。
        /// </summary>
        public string FontWeight { get; set; } = "normal";
        /// <summary>
        /// 字体风格。从 `v5.0.1` 开始支持。
        /// </summary>
        public string FontStyle { get; set; } = "normal";
        /// <summary>
        /// 字体系列。从 `v5.0.1` 开始支持。
        /// </summary>
        public string FontFamily { get; set; } = "sans-serif";

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
