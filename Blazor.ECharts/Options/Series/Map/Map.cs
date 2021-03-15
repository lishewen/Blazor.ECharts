using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Map
{
    public record Map : SeriesBase
    {
        public Map() : base("map") { }

        public string MapType { set; get; }
        public Label Label { set; get; }

        /// <summary>
        /// 自定义地区的名称映射
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-map.nameMap">此处</see>查看详细设置</para>
        /// </summary>
        public object NameMap { set; get; }

        /// <summary>
        /// 是否开启鼠标缩放和平移漫游。默认不开启。如果只想要开启缩放或者平移，可以设置成 'scale' 或者 'move'。设置成 true 为都开启
        /// </summary>
        public object Roam { set; get; }

        /// <summary>
        /// 当前视角的缩放比例。
        /// </summary>
        public double? Zoom { set; get; }

        /// <summary>
        /// layoutCenter 和 layoutSize 提供了除了 left/right/top/bottom/width/height 之外的布局手段。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-map.layoutCenter">此处</see>查看详细设置</para>
        /// </summary>
        public object[] LayoutCenter { set; get; }

        /// <summary>
        /// 地图的大小，见 layoutCenter。支持相对于屏幕宽高的百分比或者绝对的像素大小。
        /// </summary>
        public object LayoutSize { set; get; }
    }
}
