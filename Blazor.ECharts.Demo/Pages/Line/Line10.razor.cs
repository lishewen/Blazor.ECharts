using Blazor.ECharts.Demo.Utils;
using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using L = Blazor.ECharts.Options.Series.Line;
namespace Blazor.ECharts.Demo.Pages.Line
{
    [RouteName("Draggable Points")]
    public partial class Line10
    {
        private EChartsOption<L.Line> Option;
        int symbolSize = 20;
        double[,] data = {
            { 40, -10 },
            { -30, -5 },
            { -76.5, 20 },
            { -63.5, 40 },
            { -22.1, 50 }
        };
        protected override void OnInitialized()
        {
            base.OnInitialized();
            Option = new()
            {
                Title = new()
                {
                    Text = "Try Dragging these Points",
                    Left = "center"
                },
                Tooltip = new()
                {
                    TriggerOn = "none",
                    Formatter = new JFunc("""
                        function (params) {
                          return (
                            'X: ' +
                            params.data[0].toFixed(2) +
                            '<br>Y: ' +
                            params.data[1].toFixed(2)
                          );
                        }
                        """)
                },
                Grid = new()
                {
                    new()
                    {
                        Top = "8%",
                        Bottom = "12%"
                    }
                },
                XAxis = new()
                {
                    new()
                    {
                        Min = -100,
                        Max = 70,
                        Type = AxisType.Value,
                        AxisLine = new()
                        {
                            OnZero = false
                        }
                    }
                },
                YAxis = new()
                {
                    new()
                    {
                        Min = -30,
                        Max = 60,
                        Type = AxisType.Value,
                        AxisLine = new()
                        {
                            OnZero = false
                        }
                    }
                },
                DataZoom = new()
                {
                    new
                    {
                        type = "slider",
                        xAxisIndex = 0,
                        filterMode = "none"
                    },
                    new
                    {
                        type = "slider",
                        yAxisIndex = 0,
                        filterMode = "none"
                    },
                    new
                    {
                        type = "inside",
                        xAxisIndex = 0,
                        filterMode = "none"
                    },
                    new
                    {
                        type = "inside",
                        yAxisIndex = 0,
                        filterMode = "none"
                    }
                },
                Series = new()
                {
                    new L.Line()
                    {
                        Smooth = true,
                        SymbolSize = symbolSize,
                        Data = data
                    }
                }
            };
        }
    }
}