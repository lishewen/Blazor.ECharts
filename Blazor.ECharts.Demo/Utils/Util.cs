using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.ECharts.Demo.Utils
{
    public static class Util
    {
        /// <summary>
        /// 获取随机颜色
        /// </summary>
        /// <returns></returns>
        public static string GetRandomColor()
        {
            Random random = new();
            return string.Format("#{0:X6}", random.Next(0x1000000));
        }
    }
}
