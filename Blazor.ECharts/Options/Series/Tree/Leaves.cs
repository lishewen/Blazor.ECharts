using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Tree
{
    /// <summary>
    /// 叶子节点的特殊配置，如上面的树图实例中，叶子节点和非叶子节点的标签位置不同。
    /// </summary>
    public record Leaves
    {
        public Label Label { get; set; }
    }
}
