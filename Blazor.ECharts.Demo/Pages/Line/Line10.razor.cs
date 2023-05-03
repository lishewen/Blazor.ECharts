using Blazor.ECharts.Components;
using Blazor.ECharts.Demo.Utils;
using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        ELine eLine;
        // 添加事件
        private List<EventType> EventTypes = new() { EventType.datazoom };
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

        private void ShowTooltip(int dataIndex)
        {
            eLine.DispatchAction(new()
            {
                Type = "showTip",
                SeriesIndex = 0,
                DataIndex = dataIndex
            });
        }

        private void HideTooltip()
        {
            eLine.DispatchAction(new()
            {
                Type = "hideTip"
            });
        }

        private async Task UpdatePosition()
        {
            ArrayList arrayList = new();
            for (int i = 0; i < 5; i++)
            {
                double[] row = data.Cast<double>().Skip(i * 2).Take(2).ToArray();
                arrayList.Add(await eLine.ConvertToPixel("grid", row));
            }
            _ = eLine.SetupOptionAsync(new EChartsOption<L.Line>()
            {
                Graphic = new()
                {
                    new GraphicCircle()
                    {
                        Position = arrayList.ToArray()
                    }
                }
            });
        }

        private void OnEchartsEvent(EchartsEventArgs args)
        {
            if (args.EventType == EventType.datazoom)
            {
                _ = UpdatePosition();
            }
        }
    }
}