using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record BMap
    {
        public double[] Center { get; set; }
        public int Zoom { get; set; }
        public bool Roam { get; set; }
        public Mapstyle MapStyle { get; set; }
    }

    public record Mapstyle
    {
        public List<Stylejson> StyleJson { get; set; }
    }

    public record Stylejson
    {
        public string FeatureType { get; set; }
        public string ElementType { get; set; }
        public Stylers Stylers { get; set; }
    }

    public record Stylers
    {
        public string Color { get; set; }
        public string Visibility { get; set; }
        public int? Lightness { get; set; }
    }

}
