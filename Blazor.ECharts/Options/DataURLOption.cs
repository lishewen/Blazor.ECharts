using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record DataURLOption
    {
        /// <summary>
        /// 导出的格式，可选 png, jpg, svg
        /// 注意：png, jpg 只有在 canvas 渲染器的时候可使用，svg 只有在使用 svg 渲染器的时候可用
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 导出的图片分辨率比例，默认为 1。
        /// </summary>
        public int? PixelRatio {  get; set; }
        /// <summary>
        /// 导出的图片背景色，默认使用 option 里的 backgroundColor
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// 忽略组件的列表，例如要忽略 toolbox 就是 ['toolbox']
        /// </summary>
        public string[] ExcludeComponents { get; set; }
    }
}
