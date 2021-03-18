using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Graph
{
    /// <summary>
    /// 关系图
    /// </summary>
    public record Graph : SeriesBase
    {
        public Graph() : base("graph") { }
        public Layout Layout { get; set; }
        /// <summary>
        /// 节点大小
        /// </summary>
        public object SymbolSize { set; get; }
        /// <summary>
        /// 鼠标悬停在节点上时，会隐藏和当前节点非直接连接的节点
        /// </summary>
        public bool FocusNodeAdjacency { get; set; }
        public List<GraphCategory> Categories { get; set; }
        public Label Label { get; set; }
        public GraphForce Force { get; set; }
        public Label EdgeLabel { get; set; }
        public List<GraphLink> Links { get; set; }
        public LineStyle LineStyle { get; set; }
    }
}
