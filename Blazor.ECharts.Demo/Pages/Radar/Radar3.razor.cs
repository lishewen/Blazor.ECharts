using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using Blazor.ECharts.Options.Series;
using System.Collections.Generic;
using System.Linq;
using R = Blazor.ECharts.Options.Series.Radar;
namespace Blazor.ECharts.Demo.Pages.Radar
{
    public partial class Radar3
    {
        private EChartsOption<R.Radar> Option1;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            Option1 = new()
            {
                Title = new() { Text = "Multiple Radar" },
                Tooltip = new() { Trigger = TooltipTrigger.Axis },
                Legend = new()
                {
                    Left = "center",
                    Data = new[] {
                        "A Software",
                        "A Phone",
                        "Another Phone",
                        "Precipitation",
                        "Evaporation"
                    }
                },
                Radar = [
                    new()
                    {
                        Indicator =
                        [
                            new() { Text = "Brand", Max = 100 },
                            new() { Text = "Content", Max = 100 },
                            new() { Text = "Usability", Max = 100 },
                            new() { Text = "Function", Max = 100 }
                        ],
                        Center = ["25%", "40%"],
                        Radius = 80
                    },
                    new()
                    {
                        Indicator =
                        [
                            new() { Text = "Look", Max = 100 },
                            new() { Text = "Photo", Max = 100 },
                            new() { Text = "System", Max = 100 },
                            new() { Text = "Performance", Max = 100 },
                            new() { Text = "Screen", Max = 100 }
                        ],
                        Radius = 80,
                        Center = ["50%", "60%"]
                    },
                    new()
                    {
                        Indicator = GetMonthRadarIndicators().ToList(),
                        Center = ["75%", "40%"],
                        Radius = 80
                    },
                ],
                Series =
                [
                    new R.Radar()
                    {
                        Tooltip = new() { Trigger = TooltipTrigger.Item },
                        AreaStyle = new(),
                        Data = new[]
                        {
                            new SeriesData()
                            {
                                Name = "A Software",
                                Value = new[] { 60, 73, 85, 40 }
                            }
                        }
                    },
                    new R.Radar()
                    {
                        RadarIndex = 1,
                        AreaStyle = new(),
                        Data = new[]
                        {
                            new SeriesData()
                            {
                                Name = "A Phone",
                                Value = new[] { 85, 90, 90, 95, 95 }
                            },
                            new SeriesData()
                            {
                                Name = "Another Phone",
                                Value = new[] { 95, 80, 95, 90, 93 }
                            }
                        }
                    },
                    new R.Radar()
                    {
                        RadarIndex = 2,
                        AreaStyle = new(),
                        Data = new[]
                        {
                            new SeriesData()
                            {
                                Name = "Precipitation",
                                Value = new[] { 2.6, 5.9, 9.0, 26.4, 28.7, 70.7, 75.6, 82.2, 48.7, 18.8, 6.0, 2.3 }
                            },
                            new SeriesData()
                            {
                                Name = "Evaporation",
                                Value = new[] { 2.0, 4.9, 7.0, 23.2, 25.6, 76.7, 35.6, 62.2, 32.6, 20.0, 6.4, 3.3 }
                            }
                        }
                    }
                ]
            };
        }
        private static IEnumerable<RadarIndicator> GetMonthRadarIndicators()
        {
            for (var i = 1; i <= 12; i++)
            {
                yield return new RadarIndicator
                {
                    Text = $"{i}月",
                    Max = 100
                };
            }
        }
    }
}