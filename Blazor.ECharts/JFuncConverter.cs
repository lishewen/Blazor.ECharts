using Blazor.ECharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    public class JFuncConverter : JsonConverter<JFunc>
    {
        public override JFunc Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, JFunc value, JsonSerializerOptions options)
        {
            writer.WriteRawValue(value.RAW, true);
        }
    }
}