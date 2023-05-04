using Blazor.ECharts.Components;
using Blazor.ECharts.Demo.Utils;
using Blazor.ECharts.Options;
using B = Blazor.ECharts.Options.Series.Bar;
namespace Blazor.ECharts.Demo.Pages.Bar
{
    [RouteName("doc-example/barGrid-barGap")]
    public partial class Bar4
    {
        private EChartsOption<B.Bar> Option;
        string[] barGaps = new[] { "30%", "-100%" };
        int loopIndex = 0;
        EBar eBar;
        System.Threading.Timer timer;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            Option = new EChartsOption<B.Bar>()
            {
                XAxis = new()
                {
                    new()
                    {
                        Data = new[] {"a","b","c","d"},
                        AxisTick = new()
                        {
                            Show = false,
                        },
                        AxisLabel = new()
                        {
                            Formatter = "barGap: '-100%'"
                        }
                    }
                },
                YAxis = new()
                {
                    new()
                    {
                        SplitLine=new()
                        {
                            Show = false,
                        }
                    }
                },
                AnimationDurationUpdate = 1200,
                Series = new()
                {
                    new B.Bar
                    {
                        ItemStyle = new()
                        {
                            Color = "#ddd"
                        },
                        Silent = true,
                        BarWidth = "40",
                        BarGap = "-100%",
                        Data = new[] {60,60,60,60}
                    },
                    new B.Bar
                    {
                        BarWidth = "40",
                        Z = 10,
                        Data = new[] {45,60,13,25}
                    }
                }
            };

            timer = new System.Threading.Timer(Interval, new System.Threading.AutoResetEvent(false), 2000, 2000);
        }

        private void Interval(object state)
        {
            var barGap = barGaps[loopIndex];
            _ = eBar.SetupOptionAsync(new EChartsOption<B.Bar>()
            {
                XAxis = new()
                {
                    new()
                    {
                        AxisLabel = new()
                        {
                            Formatter = $"barGap: '{barGap}'"
                        }
                    }
                },
                Series = new()
                {
                    new B.Bar
                    {
                        BarGap = barGap
                    }
                }
            });
            loopIndex = (loopIndex + 1) % barGaps.Length;
        }
    }
}