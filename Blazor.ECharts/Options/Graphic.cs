using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record Graphic
    {
        public Graphic() { }
        public Graphic(string type) { Type = type; }
        /// <summary>
        /// 用 setOption 首次设定图形元素时必须指定。
        /// </summary>
        public string Type { set; get; }

        /// <summary>
        /// id 用于在更新或删除图形元素时指定更新哪个图形元素，如果不需要用可以忽略。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 描述怎么根据父元素进行定位。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic.elements-image.left">此处</see>查看详细设置</para>
        /// </summary>
        public object Left { set; get; }

        /// <summary>
        /// 描述怎么根据父元素进行定位。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic.elements-image.right">此处</see>查看详细设置</para>
        /// </summary>
        public object Right { set; get; }

        /// <summary>
        /// 描述怎么根据父元素进行定位。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic.elements-image.top">此处</see>查看详细设置</para>
        /// </summary>
        public object Top { set; get; }

        /// <summary>
        /// 描述怎么根据父元素进行定位。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic.elements-image.bottom">此处</see>查看详细设置</para>
        /// </summary>
        public object Bottom { set; get; }

        /// <summary>
        /// z 方向的高度，决定层叠关系。
        /// </summary>
        public int? Z { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public object Bounding { set; get; }

        /// <summary>
        /// 图形元素可以进行标准的 2D transform
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic.elements-image.origin">此处</see>查看详细设置</para>
        /// </summary>
        public int[] Origin { set; get; }

        public GraphicStyle Style { set; get; }

        /// <summary>
        /// 图形元素可以进行标准的 2D transform
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#graphic.elements-group.rotation">此处</see>查看详细设置</para>
        /// </summary>
        public object Rotation { set; get; }
    }
    public record GraphicGroup : Graphic
    {
        public GraphicGroup() : base("group") { }

        /// <summary>
        /// 子节点列表，其中项都是一个图形元素定义。
        /// </summary>
        public List<object> Children { set; get; }
    }
    public record GraphicImage : Graphic
    {
        public GraphicImage() : base("image") { }

    }
    public record GraphicStyle
    {
        /// <summary>
        /// 图片的内容，可以是图片的 URL，也可以是 dataURI.
        /// </summary>
        public string Image { set; get; }

        /// <summary>
        /// 图形元素的宽度。
        /// </summary>
        public int? Width { set; get; }

        /// <summary>
        /// 图形元素的高度。
        /// </summary>
        public int? Height { set; get; }

        public double? Opacity { set; get; }
    }
}
