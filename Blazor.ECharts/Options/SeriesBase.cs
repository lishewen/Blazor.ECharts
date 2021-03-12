using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public class SeriesBase
    {
        public SeriesBase(string type, string id = null, string name = null)
        {
            Type = type;
            Id = id;
            Name = name;
        }

        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string Type { set; get; } = "line";

        /// <summary>
        /// 系列名称，用于tooltip的显示，legend 的图例筛选，在 setOption 更新数据和配置项时用于指定对应的系列。
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 初始动画的延迟，支持回调函数，可以通过每个数据返回不同的 delay 时间实现更戏剧的初始动画效果。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-bar.markPoint.animationDelay">此处</see>查看详细设置</para>
        /// </summary>
        public object AnimationDelay { set; get; }
    }
}
