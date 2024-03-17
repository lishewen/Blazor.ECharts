using Blazor.ECharts.Components;
using Blazor.ECharts.Demo.Utils;
using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using System.Threading.Tasks;
using B = Blazor.ECharts.Options.Series.Boxplot;
using S = Blazor.ECharts.Options.Series.Scatter;

namespace Blazor.ECharts.Demo.Pages.Boxplot
{
    [RouteName("基础盒须图(Michelson-Morley Experiment)/getDataUrl")]
    public partial class Boxplot1
    {
        EBoxplot eBoxplot;
        private EChartsOption<B.Boxplot> Option1;
        private string imageSource;

        private async Task GetDataUrl()
        {
            imageSource = await eBoxplot.GetDataURL(new()
            {
                PixelRatio = 2,
                BackgroundColor = "#fff"
            });
        }

        protected override void OnInitialized()
        {
            Option1 = new()
            {
                Title = new()
                {
                    Text = "Michelson-Morley Experiment",
                    Left = "center"
                },
                Dataset = [
                    new()
                    {
                        Source = new int[][]
                        {
                            [850, 740, 900, 1070, 930, 850, 950, 980, 980, 880, 1000, 980, 930, 650, 760, 810, 1000, 1000, 960, 960],
                            [960, 940, 960, 940, 880, 800, 850, 880, 900, 840, 830, 790, 810, 880, 880, 830, 800, 790, 760, 800],
                            [880, 880, 880, 860, 720, 720, 620, 860, 970, 950, 880, 910, 850, 870, 840, 840, 850, 840, 840, 840],
                            [890, 810, 810, 820, 800, 770, 760, 740, 750, 760, 910, 920, 890, 860, 880, 720, 840, 850, 850, 780],
                            [890, 840, 780, 810, 760, 810, 790, 810, 820, 850, 870, 870, 810, 740, 810, 940, 950, 800, 810, 870]
                        },
                    },
                    new()
                    {
                        Transform = new()
                        {
                            Type = "boxplot",
                            Config = new()
                            {
                                ItemNameFormatter = new JFunc("""
                                    function (params) {
                                      return 'expr ' + params.value;
                                    }
                                """)
                            }
                        }
                    },
                    new()
                    {
                        FromDatasetIndex = 1,
                        FromTransformResult = 1
                    }
                ],
                Tooltip = new()
                {
                    Trigger = TooltipTrigger.Item,
                    AxisPointer = new()
                    {
                        Type = AxisPointerType.Shadow
                    }
                },
                Grid = [
                    new()
                    {
                        Left = "10%",
                        Right = "10%",
                        Bottom = "15%"
                    }
                ],
                YAxis = [
                    new()
                    {
                        Type = AxisType.Category,
                        BoundaryGap = true,
                        NameGap = 30,
                        SplitArea = new()
                        {
                            Show = false
                        },
                        SplitLine = new()
                        {
                            Show = false
                        },
                    }
                ],
                XAxis = [
                    new()
                    {
                        Type = AxisType.Value,
                        Name = "km/s minus 299,000",
                        SplitArea = new()
                        {
                            Show = false
                        }
                    }
                ],
                Series = [
                    new B.Boxplot
                    {
                        Name = "boxplot",
                        DatasetIndex = 1
                    },
                    new S.Scatter
                    {
                        Name = "outlier",
                        Encode = new()
                        {
                            X = 1,
                            Y = 0
                        },
                        DatasetIndex = 2
                    }
                ]
            };
            base.OnInitialized();
        }
    }
}
