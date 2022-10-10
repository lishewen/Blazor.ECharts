using Blazor.ECharts.Options;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using M = Blazor.ECharts.Options.Series.Map;

namespace Blazor.ECharts.Demo.Pages.Map
{
    public partial class BeefcutsFrance
    {
        private EChartsOption<M.Map> Option1;
        [Inject]
        public HttpClient Http { get; set; }
        [Inject]
        public JsInterop JsInterop { get; set; }
        protected async override Task OnInitializedAsync()
        {
            var svg = await Http.GetStringAsync("sample-data/Beef_cuts_France.svg");
            await JsInterop.RegisterMap("Beef_cuts_France", svg);

            Option1 = new()
            {
                Tooltip = new(),
                VisualMap = new
                {
                    Left = "center",
                    Bottom = "10%",
                    Min = 5,
                    Max = 100,
                    Orient = "horizontal",
                    Text = new[] { "", "Price" },
                    Realtime = true,
                    Calculable = true,
                    InRange = new
                    {
                        Color = new[] { "#dbac00", "#db6e00", "#cf0000" }
                    }
                },
                Series = new()
                {
                    new M.Map()
                    {
                        Name="French Beef Cuts",
                        MapName="Beef_cuts_France",
                        Roam=true,
                        Emphasis=new(){
                            Label = new()
                            {
                                Show=false
                            }
                        },
                        SelectedMode=false,
                        Data = new[]
                        {
                            new{Name="Queue",Value=15},
                            new{Name="Langue",Value=35},
                            new{Name="Plat de joue",Value=15},
                            new{Name="Gros bout de poitrine",Value=25},
                            new{Name="Jumeau à pot-au-feu",Value=45},
                            new{Name="Onglet",Value=85},
                            new{Name="Plat de tranche",Value=25},
                            new{Name="Araignée",Value=15},
                            new{Name="Gîte à la noix",Value=55},
                            new{Name="Bavette d'aloyau",Value=25},
                            new{Name="Tende de tranche",Value=65},
                            new{Name="Rond de gîte",Value=45},
                            new{Name="Bavettede de flanchet",Value=85},
                            new{Name="Flanchet",Value=35},
                            new{Name="Hampe",Value=75},
                            new{Name="Plat de côtes",Value=65},
                            new{Name="Tendron Milieu de poitrine",Value=65},
                            new{Name="Macreuse à pot-au-feu",Value=85},
                            new{Name="Rumsteck",Value=75},
                            new{Name="Faux-filet",Value=65},
                            new{Name="Côtes Entrecôtes",Value=55},
                            new{Name="Basses côtes",Value=45},
                            new{Name="Collier",Value=85},
                            new{Name="Jumeau à biftek",Value=15},
                            new{Name="Paleron",Value=65},
                            new{Name="Macreuse à bifteck",Value=45},
                            new{Name="Gîte",Value=85},
                            new{Name="Aiguillette baronne",Value=65},
                            new{Name="Filet",Value=95}
                        }
                    }
                }
            };

            await base.OnInitializedAsync();
        }
    }
}