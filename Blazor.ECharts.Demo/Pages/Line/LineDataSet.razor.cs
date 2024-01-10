using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;
using L = Blazor.ECharts.Options.Series.Line;
namespace Blazor.ECharts.Demo.Pages.Line
{
    public partial class LineDataSet
    {
        private EChartsOption<L.Line> Option1;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            object[,] sr = new object[4, 3] {
                                                { 43.3, 85.8, 93.7},
                                                { 83.1, 73.4, 55.1},
                                                { 86.4, 65.2, 82.5},
                                                {72.4, 53.9, 39.1} };

            Option1 = new()
            {
                Tooltip = new Tooltip(),
                Dataset = new DataSet
                {
                    Dimensions = ["Income", "Life Expectancy", "Population"],
                    Source = sr

                },
                Title = new()
                {
                    Text = "折线图"
                },
                YAxis =
                [
                    new YAxis()
                    {
                        Type = AxisType.Value,
                        Name = "Population"
                    }
                ],
                XAxis =
                [
                    new XAxis()
                    {
                        Type = AxisType.Value,
                        Name = "Income"
                        //Data = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }
                    }
                ],
                Series = [
                new L.Line()
                {
                    Type = "line",
                    // Data = new[] { 820, 932, 901, 934, 1290, 1330, 1320 }
                    Encode = new Options.Series.Encode()
                    {
                        X = "Income",
                        Y = "Population",
                        Tooltip = new int[3] { 0, 1, 2 }
                    }
                }
            ]
            };

        }
    }
}