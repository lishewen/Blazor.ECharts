using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 提示框组件。
    /// </summary>
    public class Tooltip
    {
        /// <summary>
        /// 是否显示提示框组件，包括提示框浮层和 axisPointer
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 触发类型。
        /// </summary>
        public TooltipTrigger? Trigger { set; get; }

        /// <summary>
        /// 提示框触发的条件
        /// </summary>
        public string TriggerOn { get; set; }

        /// <summary>
        /// 坐标轴指示器配置项。
        /// </summary>
        public TooltipAxisPointer AxisPointer { set; get; }

        /// <summary>
        /// 提示框浮层的位置，默认不设置时位置会跟随鼠标的位置。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#tooltip.position">此处</see>查看详细设置</para>
        /// </summary>
        public object Position { set; get; }

        /// <summary>
        /// 提示框浮层内容格式器，支持字符串模板和回调函数两种形式。
        /// <para>点击<see href="https://echarts.apache.org/zh/option.html#tooltip.formatter">此处</see>查看详细设置</para>
        /// </summary>
        public object Formatter { set; get; }

        /// <summary>
        /// 提示框浮层的背景颜色。
        /// </summary>
        public object BackgroundColor { set; get; }

        /// <summary>
        /// 提示框浮层的边框宽。
        /// </summary>
        public int? BorderWidth { set; get; }

        /// <summary>
        /// 提示框浮层的边框颜色。
        /// </summary>
        public object BorderColor { set; get; }

        /// <summary>
        /// 提示框浮层内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距。
        /// </summary>
        public object Padding { set; get; }

        public TextStyle TextStyle { set; get; }

        /// <summary>
        /// tooltip 中数值显示部分的格式化回调函数。
        /// </summary>
        public JFunc ValueFormatter { get; set; }
    }
}
