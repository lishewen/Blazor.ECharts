using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using L = Blazor.ECharts.Options.Series.Line;

namespace Blazor.ECharts.WebApp.Demo.Client.Pages.Timeline
{
    public partial class AreaTimeAxis
    {
        private EChartsOption<L.Line> Option1;
        protected override void OnInitialized()
        {
            DateOnly dbase = new(1988, 9, 3);
            Dictionary<DateOnly, int> data = new()
            {
                { dbase, Random.Shared.Next(1, 300) }
            };

            for(int i = 1; i < 20000; i++)
            {
                var now = dbase.AddDays(i);
                data.Add(now, Random.Shared.Next(-20, 320));
            }

            Option1 = new()
            {
                Tooltip = new()
                {
                    Trigger = TooltipTrigger.Axis,
                    Position = new JFunc()
                    {
                        RAW = """
                        function (pt) {
                          return [pt[0], '10%'];
                        }
                        """
                    }
                },
                Title = new()
                {
                    Left = "center",
                    Text = "Large Ara Chart"
                },
                Toolbox = new()
                {
                    Feature = new()
                    {
                        DataZoom = new()
                        {
                            YAxisIndex = "none"
                        },
                        Restore = new(),
                        SaveAsImage = new()
                    }
                },
                XAxis = new()
                {
                    new()
                    {
                        Type = AxisType.Time,
                        BoundaryGap = false
                    }
                },
                YAxis = new()
                {
                    new()
                    {
                        Type = AxisType.Value,
                        BoundaryGap = new[] { "0", "100%" }
                    }
                },
                DataZoom = new()
                {
                    new
                    {
                        Type = "inside",
                        Start = 0,
                        End = 20
                    },
                    new
                    {
                        Start = 0,
                        End = 20
                    }
                },
                Series = new()
                {
                    new L.Line()
                    {
                        Name = "Fake Data",
                        Smooth = true,
                        Symbol = "none",
                        AreaStyle = new(),
                        Data = data.Select(item => new long[] { ToUnixTimestampByMilliseconds(item.Key), item.Value }).ToArray()
                    }
                }
            };

            base.OnInitialized();
        }

        /// <summary>
        ///  时间转时间戳Unix-时间戳精确到毫秒
        /// </summary> 
        private static long ToUnixTimestampByMilliseconds(DateOnly dt)
        {
            DateTimeOffset dto = new(dt.ToDateTime(new TimeOnly(0)));
            return dto.ToUnixTimeMilliseconds();
        }
    }
}