using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blazor.ECharts.Options
{
    internal class EChartsOptionSerializer
    {
        public static readonly EChartsOptionSerializer Default = new();

        private readonly JsonSerializerOptions _options;

        private EChartsOptionSerializer()
        {
            _options = new()
            {
                PropertyNamingPolicy   = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
                    new JFuncConverter(),
                    new Array2DConverter()
                }
            };
        }

        public string Serialize(object option)
        {
            return JsonSerializer.Serialize(option, _options);
        }
    }
}