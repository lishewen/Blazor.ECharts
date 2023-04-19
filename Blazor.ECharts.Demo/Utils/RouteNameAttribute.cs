using System;

namespace Blazor.ECharts.Demo.Utils
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class RouteNameAttribute : Attribute
    {
        public RouteNameAttribute(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public string Name { get; }
    }
}
