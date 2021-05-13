using Blazor.ECharts.Options;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    public class EventInvokeHelper
    {
        private readonly Action<EchartsEventArgs> _action;

        public EventInvokeHelper(Action<EchartsEventArgs> action)
        {
            _action = action;
        }

        [JSInvokable]
        public void EventCaller(string args)
        {
            JsonSerializerOptions jsonSerializerOptions = new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                }
            };
            _action.Invoke(JsonSerializer.Deserialize<EchartsEventArgs>(args, jsonSerializerOptions));
        }
    }
}
