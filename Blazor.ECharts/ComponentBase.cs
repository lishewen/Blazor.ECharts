using Blazor.ECharts.Options;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    public class ComponentBase<T> : ComponentBase
    {
        protected string Id = "echerts_" + Guid.NewGuid().ToString("N");

        [Parameter]
        public EChartsOption<T> Option { get; set; }
    }
}
