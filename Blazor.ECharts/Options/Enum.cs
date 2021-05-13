using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Enum
{
    public enum Align
    {
        Auto,
        Left,
        Right,
        Center
    }


    public enum Align1
    {
        Auto,
        Left,
        Right
    }


    public enum Align2
    {
        Left,
        Right,
        Center
    }


    public enum VerticalAlign
    {
        Top,
        Middle,
        Bottom
    }


    public enum AxisType
    {
        /// <summary>
        /// 数值轴，适用于连续数据。
        /// </summary>
        Value,
        /// <summary>
        /// 类目轴，适用于离散的类目数据，为该类型时必须通过 data 设置类目数据
        /// </summary>
        Category,
        /// <summary>
        /// 时间轴，适用于连续的时序数据，与数值轴相比时间轴带有时间的格式化，在刻度计算上也有所不同，例如会根据跨度的范围来决定使用月，星期，日还是小时范围的刻度。
        /// </summary>
        Time,
        /// <summary>
        /// 对数轴。适用于对数数据。
        /// </summary>
        Log
    }


    public enum Location
    {
        Start,
        Middle,
        End
    }


    public enum PositionY
    {
        Start,
        End
    }


    public enum PositionX
    {
        Top,
        Bottom
    }

    /// <summary>
    /// 指示器的坐标轴。
    /// </summary>

    public enum AxisPointerAxis
    {
        X,
        Y,
        Radius,
        Angle
    }

    /// <summary>
    /// 指示器类型。
    /// </summary>

    public enum AxisPointerType
    {
        /// <summary>
        /// 直线指示器
        /// </summary>
        Line,
        /// <summary>
        /// 阴影指示器
        /// </summary>
        Shadow,
        /// <summary>
        /// 无指示器
        /// </summary>
        None,
        /// <summary>
        /// 十字准星指示器。其实是种简写，表示启用两个正交的轴的 axisPointer。
        /// </summary>
        Cross
    }


    public enum TooltipTrigger
    {
        /// <summary>
        /// 数据项图形触发，主要在散点图，饼图等无类目轴的图表中使用。
        /// </summary>
        Item,
        /// <summary>
        /// 坐标轴触发，主要在柱状图，折线图等会使用类目轴的图表中使用。
        /// <para>支持在直角坐标系和极坐标系上的所有类型的轴。并且可以通过 axisPointer.axis 指定坐标轴。</para>
        /// </summary>
        Axis,
        /// <summary>
        /// 什么都不触发。
        /// </summary>
        None
    }


    public enum CoordinateSystem
    {
        /// <summary>
        /// 使用二维的直角坐标系（也称笛卡尔坐标系），通过 xAxisIndex, yAxisIndex指定相应的坐标轴组件。
        /// </summary>
        Cartesian2d,
        /// <summary>
        /// 使用极坐标系，通过 polarIndex 指定相应的极坐标组件
        /// </summary>
        Polar,
        /// <summary>
        /// 百度地图
        /// </summary>
        Bmap,
        /// <summary>
        /// 使用地理坐标系，通过 geoIndex 指定相应的地理坐标系组件。
        /// </summary>
        Geo
    }

    /// <summary>
    /// 图形区域的起始位置
    /// </summary>

    public enum Origin
    {
        /// <summary>
        /// 填充坐标轴轴线到数据间的区域
        /// </summary>
        Auto,
        /// <summary>
        /// 填充坐标轴底部（非 inverse 情况是最小值）到数据间的区域
        /// </summary>
        Start,
        /// <summary>
        ///  填充坐标轴顶部（非 inverse 情况是最大值）到数据间的区域
        /// </summary>
        End
    }

    /// <summary>
    /// 平铺类型
    /// </summary>

    public enum FillColorRepeat
    {
        RepeatX,
        RepeatY,
        NoRepeat
    }

    /// <summary>
    /// 指定窗口打开主标题超链接。
    /// </summary>

    public enum Target
    {
        /// <summary>
        /// 当前窗口打开
        /// </summary>
        Self,
        /// <summary>
        ///  新窗口打开
        /// </summary>
        Blank
    }

    /// <summary>
    /// 主标题文字字体的风格
    /// </summary>

    public enum FontStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        Italic,
        Oblique
    }

    /// <summary>
    /// 主标题文字字体的粗细
    /// </summary>

    public enum FontWeight
    {
        Normal,
        Bold,
        Bolder,
        Lighter
    }

    /// <summary>
    /// 图例的类型
    /// </summary>

    public enum LegendType
    {
        /// <summary>
        /// 普通图例。缺省就是普通图例。
        /// </summary>
        plain,
        /// <summary>
        /// 可滚动翻页的图例。当图例数量较多时可以使用。
        /// </summary>
        scroll
    }

    /// <summary>
    /// 布局朝向。
    /// </summary>

    public enum Orient
    {
        /// <summary>
        /// 
        /// </summary>
        Horizontal,
        /// <summary>
        /// 
        /// </summary>
        Vertical
    }


    public enum SelectorPosition
    {
        /// <summary>
        /// 
        /// </summary>
        Start,
        End
    }

    /// <summary>
    /// dataZoom 的运行原理是通过 数据过滤 来达到 数据窗口缩放 的效果。数据过滤模式的设置不同，效果也不同。
    /// </summary>

    public enum FilterMode
    {
        Filter,
        WeakFilter,
        Empty,
        None
    }


    public enum RangeMode
    {
        Value,
        Percent
    }


    public enum LineStyleType
    {
        Solid,
        Dashed,
        Dotted
    }


    public enum Sampling
    {
        /// <summary>
        /// 取过滤点的平均值
        /// </summary>
        Average,
        /// <summary>
        /// 取过滤点的最大值
        /// </summary>
        Max,
        /// <summary>
        /// 取过滤点的最小值
        /// </summary>
        Min,
        /// <summary>
        ///  取过滤点的和
        /// </summary>
        Sum
    }

    /// <summary>
    /// 渐变类型
    /// </summary>

    public enum ColorType
    {
        /// <summary>
        /// 线性渐变，前四个参数分别是 x0, y0, x2, y2, 范围从 0 - 1，相当于在图形包围盒中的百分比，如果 globalCoord 为 `true`，则该四个值是绝对的像素位置
        /// </summary>
        Linear,
        /// <summary>
        /// 径向渐变，前三个参数分别是圆心 x, y 和半径，取值同线性渐变
        /// </summary>
        Radial
    }

    /// <summary>
    /// 动态类型
    /// </summary>

    public enum MagicTypeType
    {
        /// <summary>
        /// 切换为折线图
        /// </summary>
        Line,
        /// <summary>
        /// 切换为柱状图
        /// </summary>
        Bar,
        /// <summary>
        /// 切换为堆叠模式
        /// </summary>
        Stack,
        /// <summary>
        /// 切换为平铺模式
        /// </summary>
        Tiled
    }
    /// <summary>
    /// 特殊的标注类型，用于标注最大值最小值等。
    /// </summary>

    public enum MarkPointDataType
    {
        /// <summary>
        /// 取过滤点的平均值
        /// </summary>
        Average,
        /// <summary>
        /// 取过滤点的最大值
        /// </summary>
        Max,
        /// <summary>
        /// 取过滤点的最小值
        /// </summary>
        Min
    }

    /// <summary>
    /// 标签的位置。
    /// </summary>

    public enum LabelPosition
    {
        /// <summary>
        /// 饼图扇区外侧，通过视觉引导线连到相应的扇区。
        /// </summary>
        Uutside,
        /// <summary>
        /// 饼图扇区内部。
        /// </summary>
        Inside,
        /// <summary>
        /// 同 'inside'
        /// </summary>
        Inner,
        /// <summary>
        /// 在饼图中心位置。见圆环图示例
        /// </summary>
        Center,
        /// <summary>
        /// 非叶子节点的标签在上部
        /// </summary>
        Top,
        /// <summary>
        /// 叶子节点的标签在节点右边
        /// </summary>
        Right
    }

    /// <summary>
    /// 选择模式
    /// </summary>

    public enum SelectedMode
    {
        /// <summary>
        /// 单选
        /// </summary>
        Single,
        /// <summary>
        /// 多选
        /// </summary>
        Multiple
    }

    /// <summary>
    /// 雷达图绘制类型
    /// </summary>

    public enum RadarShape
    {
        Polygon,
        Circle
    }

    /// <summary>
    /// 使用的按钮
    /// </summary>
    public enum BrushType
    {
        /// <summary>
        /// 开启矩形选框选择功能。
        /// </summary>
        Rect,
        /// <summary>
        /// 开启任意形状选框选择功能。
        /// </summary>
        Polygon,
        /// <summary>
        /// 开启横向选择功能。
        /// </summary>
        LineX,
        /// <summary>
        /// 开启纵向选择功能。
        /// </summary>
        LineY,
        /// <summary>
        /// 切换『单选』和『多选』模式。后者可支持同时画多个选框。前者支持单击清除所有选框。
        /// </summary>
        Keep,
        /// <summary>
        /// 清空所有选框。
        /// </summary>
        Clear
    }
    /// <summary>
    /// 数据排序
    /// </summary>
    public enum SortType
    {
        Ascending,
        Descending,
        /// <summary>
        /// 表示按 data 顺序
        /// </summary>
        None
    }
    /// <summary>
    /// 图的布局。
    /// </summary>
    public enum Layout
    {
        /// <summary>
        /// 不采用任何布局，使用节点中提供的 x， y 作为节点的位置。
        /// </summary>
        None,
        /// <summary>
        /// 采用环形布局，见示例 Les Miserables，布局相关的配置项见 graph.circular
        /// </summary>
        Circular,
        /// <summary>
        /// 采用力引导布局，见示例 Force，布局相关的配置项见 graph.force
        /// </summary>
        Force
    }
    /// <summary>
    /// 事件类型
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// 点击
        /// </summary>
        click,

        /// <summary>
        /// 双击
        /// </summary>
        dblclick,

        /// <summary>
        /// 当鼠标指针移动到元素上方，并按下鼠标左键时，会发生 mousedown 事件。
        /// </summary>
        mousedown,

        /// <summary>
        /// 当鼠标指针在指定的元素中移动时，就会发生 mousemove 事件。
        /// </summary>
        mousemove,

        /// <summary>
        /// 当鼠标指针移动到元素上方，并松开鼠标左键时，会发生 mouseup 事件。
        /// </summary>
        mouseup,

        /// <summary>
        /// 当鼠标指针位于元素上方时，会发生 mouseover 事件。
        /// </summary>
        mouseover,

        /// <summary>
        /// 当鼠标指针离开被选元素时，会发生 mouseout 事件。
        /// </summary>
        mouseout,

        /// <summary>
        ///
        /// </summary>
        globalout,

        /// <summary>
        /// 上下文菜单（一般为右键菜单）
        /// </summary>
        contextmenu,

        /// <summary>
        /// 图例选中后的事件。
        /// </summary>
        legendselectchanged,

        /// <summary>
        /// 图例取消选中后的事件。
        /// </summary>
        legendunselected,

        /// <summary>
        /// 图例全选后的事件。
        /// </summary>
        legendselectall,

        /// <summary>
        /// 图例反选后的事件。
        /// </summary>
        legendinverseselect,

        /// <summary>
        /// 图例滚动事件。
        /// </summary>
        legendscroll,

        /// <summary>
        /// 数据区域缩放后的事件。
        /// </summary>
        datazoom,

        /// <summary>
        /// 视觉映射组件中，range 值改变后触发的事件。
        /// </summary>
        datarangeselected,

        /// <summary>
        /// 时间轴中的时间点改变后的事件。
        /// </summary>
        timelinechanged,

        /// <summary>
        ///  时间轴中播放状态的切换事件。
        /// </summary>
        timelineplaychanged,

        /// <summary>
        /// 重置 option 事件。
        /// </summary>
        restore,

        /// <summary>
        /// 工具栏中数据视图的修改事件。
        /// </summary>
        dataviewchanged,

        /// <summary>
        /// 工具栏中动态类型切换的切换事件。
        /// </summary>
        magictypechanged,

        /// <summary>
        /// geo 中地图区域切换选中状态的事件。用户点击选中会触发该事件。
        /// </summary>
        geoselectchanged,

        /// <summary>
        /// geo 中地图区域选中后的事件。
        /// 使用dispatchAction可触发此事件，用户点击不会触发此事件（用户点击事件请使用 geoselectchanged）。
        /// </summary>
        geoselected,

        /// <summary>
        /// geo 中地图区域取消选中后的事件。
        /// 使用dispatchAction可触发此事件，用户点击不会触发此事件（用户点击事件请使用 geoselectchanged）。
        /// </summary>
        geounselected,

        /// <summary>
        /// series-pie 中饼图扇形切换选中状态的事件。 用户点击选中会触发该事件。
        /// </summary>
        pieselectchanged,

        /// <summary>
        /// series-pie 中饼图扇形选中后的事件。
        /// 使用dispatchAction可触发此事件，用户点击不会触发此事件（用户点击事件请使用 pieselectchanged）。
        /// </summary>
        pieselected,

        /// <summary>
        /// series-pie 中饼图扇形取消选中后的事件.
        /// 使用dispatchAction可触发此事件，用户点击不会触发此事件（用户点击事件请使用 pieselectchanged）。
        /// </summary>
        pieunselected,

        /// <summary>
        /// series-map 中地图区域切换选中状态的事件。 用户点击选中会触发该事件。
        /// </summary>
        mapselectchanged,

        /// <summary>
        /// series-map 中地图区域选中后的事件。使用dispatchAction可触发此事件，用户点击不会触发此事件（用户点击事件请使用 mapselectchanged）。
        /// </summary>
        mapselected,

        /// <summary>
        /// series-map 中地图区域取消选中后的事件。
        /// 使用dispatchAction可触发此事件，用户点击不会触发此事件（用户点击事件请使用 mapselectchanged）。
        /// </summary>
        mapunselected,

        /// <summary>
        /// 平行坐标轴 (Parallel)范围选取事件。
        /// 当进行坐标轴范围选取时，可以用如下方式获取当前高亮的线所对应的 data indices （即 series 的 data 中的序号列表）。
        /// </summary>
        axisareaselected,

        /// <summary>
        /// graph的邻接节点高亮事件。
        /// </summary>
        focusnodeadjacency,

        /// <summary>
        /// graph的邻接节点取消高亮事件。
        /// </summary>
        unfocusnodeadjacency,

        /// <summary>
        /// “选框正在添加”事件。即发出 brush action 得到的事件。
        /// </summary>
        brush,

        /// <summary>
        /// 选框添加完毕”事件。即发出 brushEnd action 得到的事件。
        /// </summary>
        brushEnd,

        /// <summary>
        /// 对外通知当前选中了什么。
        /// </summary>
        brushselected,

        /// <summary>
        ///
        /// </summary>
        globalcursortaken,

        /// <summary>
        /// 渲染结束事件。注意 rendered 事件并不代表渲染动画（参见 animation 相关配置）或者渐进渲染（参见 progressive 相关配置）停止，只代表本帧的渲染结束。
        /// </summary>
        rendered,

        /// <summary>
        /// 渲染完成事件。当渲染动画（参见 animation 相关配置）或者渐进渲染（参见 progressive 相关配置）停止时触发。
        /// </summary>
        finished
    }
}
