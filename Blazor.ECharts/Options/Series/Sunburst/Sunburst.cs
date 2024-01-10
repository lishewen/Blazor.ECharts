using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Sunburst
{
    /// <summary>
    /// 旭日图
    /// </summary>
    public record Sunburst : SeriesBase
    {
        public Sunburst() : base("sunburst") { }
        /// <summary>
        /// 旭日图的半径。可以为如下类型：
        /// number：直接指定外半径值。
        /// string：例如，'20%'，表示外半径为可视区尺寸（容器高宽中较小一项）的 20% 长度。
        /// Array.<number|string>：数组的第一项是内半径，第二项是外半径。每一项遵从上述 number string 的描述。
        /// </summary>
        public object Radius { set; get; }
    }
}
