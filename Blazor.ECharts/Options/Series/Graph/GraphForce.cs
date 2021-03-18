using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Graph
{
    /// <summary>
    /// 力引导布局相关的配置项，力引导布局是模拟弹簧电荷模型在每两个节点之间添加一个斥力，每条边的两个节点之间添加一个引力，每次迭代节点会在各个斥力和引力的作用下移动位置，多次迭代后节点会静止在一个受力平衡的位置，达到整个模型的能量最小化。
    /// 力引导布局的结果有良好的对称性和局部聚合性，也比较美观。
    /// </summary>
    public record GraphForce
    {
        /// <summary>
        /// 节点之间的斥力因子。
        /// </summary>
        public int? Repulsion { get; set; }
    }
}
