using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.ECharts.Demo.Utils
{
    public static class Util
    {
        public static string GetRandomColor()
        {
            Random tempR = new();
            Random rR = new((int)DateTime.Now.Ticks);
            System.Threading.Thread.Sleep(tempR.Next(50));
            Random rG = new((int)DateTime.Now.Ticks);
            System.Threading.Thread.Sleep(tempR.Next(50));
            Random rB = new((int)DateTime.Now.Ticks);
            string colorR = Convert.ToString(rR.Next(rB.Next()) % 16, 16);
            string colorG = Convert.ToString(rG.Next(rR.Next()) % 16, 16);
            string colorB = Convert.ToString(rB.Next(rR.Next()) % 16, 16);
            if (colorR == "0")
            {
                colorR = "00";
            }
            if (colorG == "0")
            {
                colorG = "00";
            }
            if (colorB == "0")
            {
                colorB = "00";
            }
            return "#" + colorR + colorG + colorB;
        }
    }
}
