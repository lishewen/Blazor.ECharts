using Blazor.ECharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EChartsDIExtends
    {
        public static IServiceCollection AddECharts(this IServiceCollection services)
        {
            services.AddScoped<JsInterop>();

            return services;
        }
    }
}
