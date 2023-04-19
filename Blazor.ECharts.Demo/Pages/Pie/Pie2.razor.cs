using Blazor.ECharts.Components;
using Blazor.ECharts.Demo.Utils;
using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using System;
using System.Threading.Tasks;
using P = Blazor.ECharts.Options.Series.Pie;

namespace Blazor.ECharts.Demo.Pages.Pie
{
    [RouteName("饼图程序调用高亮示例|DispatchAction示例")]
    public partial class Pie2
    {
        // 计时器
        System.Threading.Timer timer;
        private EChartsOption<P.Pie> Option;
        private int currentIndex = -1;
        EPie ePie;
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            Option = new EChartsOption<P.Pie>
            {
                Title = new()
                {
                    Text = "饼图程序调用高亮示例",
                    Left = "center"
                },
                Tooltip = new()
                {
                    Trigger = TooltipTrigger.Item,
                    Formatter = "{a} <br/>{b}: {c} ({d}%)"
                },
                Legend = new()
                {
                    Orient = Orient.Vertical,
                    Left = "left",
                    Data = new[] { "直接访问", "邮件营销", "联盟广告", "视频广告", "搜索引擎" }
                },
                Series = new()
                {
                    new P.Pie()
                    {
                        Name = "访问来源",
                        Radius = "55%",
                        Center = new[] { "50%", "60%" },
                        Data = new[]
                        {
                            new { name = "直接访问", value = 335 },
                            new { name = "邮件营销", value = 310 },
                            new { name = "联盟广告", value = 234 },
                            new { name = "视频广告", value = 135 },
                            new { name = "搜索引擎", value = 1548 }
                        },
                        Emphasis = new()
                        {
                            ItemStyle = new()
                            {
                                ShadowBlur = 10,
                                ShadowOffsetX = 0,
                                ShadowColor = "rgba(0, 0, 0, 0.5)"
                            }
                        }
                    }
                }
            };

            timer = new System.Threading.Timer(Interval, new System.Threading.AutoResetEvent(false), 1000, 1000);
        }

        private void Interval(object state)
        {
            int dataLen = ((Option.Series[0] as P.Pie).Data as Array).Length;
            // 取消之前高亮的图形
            ePie.DispatchAction(new()
            {
                Type = "downplay",
                SeriesIndex = 0,
                DataIndex = currentIndex
            });
            currentIndex = (currentIndex + 1) % dataLen;
            // 高亮当前图形
            ePie.DispatchAction(new()
            {
                Type = "highlight",
                SeriesIndex = 0,
                DataIndex = currentIndex
            });
            // 显示tooltip
            ePie.DispatchAction(new()
            {
                Type = "showTip",
                SeriesIndex = 0,
                DataIndex = currentIndex
            });
        }
    }
}