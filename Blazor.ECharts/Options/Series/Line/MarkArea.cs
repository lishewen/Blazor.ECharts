using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Line
{
    public class MarkArea
    {
        /// <summary>
        /// 图形是否不响应和触发鼠标事件，默认为 false，即响应和触发鼠标事件。
        /// </summary>
        public bool? Silent { set; get; }

        public List<List<MarkAreaData>> Data { set; get; }
    }
    public class MarkAreaData
    {
        /// <summary>
        /// 文档中没有，示例中有？？？
        /// </summary>
        public string XAxis { set; get; }
    }
}
