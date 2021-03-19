using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.ECharts.Demo.Utils
{
    /// <summary>
    /// WGS-84、GCJ-02（火星坐标系）、BD-09（百度坐标系）之间的坐标转换器
    /// </summary>
    public static class MapConverter
    {
        /// <summary>
        /// 圆周率
        /// </summary>
        private const double PI = Math.PI;
        private const double X_PI = PI * 3000.0 / 180.0;

        /// <summary>
        /// 地理位置是否位于中国以外
        /// </summary>
        /// <param name="wgLat">WGS-84坐标纬度</param>
        /// <param name="wgLon">WGS-84坐标经度</param>
        /// <returns>
        ///     true：国外
        ///     false：国内
        /// </returns>
        public static bool OutOfChina(double wgLat, double wgLon)
        {
            if (wgLon < 72.004 || wgLon > 137.8347) return true;
            if (wgLat < 0.8293 || wgLat > 55.8271) return true;

            return false;
        }

        /// <summary>
        /// WGS-84坐标系转火星坐标系 (GCJ-02)
        /// </summary>
        /// <param name="wgLat">WGS-84坐标纬度</param>
        /// <param name="wgLon">WGS-84坐标经度</param>
        /// <param name="mgLat">输出：GCJ-02坐标纬度</param>
        /// <param name="mgLon">输出：GCJ-02坐标经度</param>
        public static void WGS84ToGCJ02(double wgLat, double wgLon, out double mgLat, out double mgLon)
        {
            if (OutOfChina(wgLat, wgLon))
            {
                mgLat = wgLat;
                mgLon = wgLon;
            }
            else
            {
                Delta(wgLat, wgLon, out double dLat, out double dLon);
                mgLat = wgLat + dLat;
                mgLon = wgLon + dLon;
            }
        }

        /// <summary>
        /// 火星坐标系 (GCJ-02)转WGS-84坐标系
        /// </summary>
        /// <param name="mgLat">GCJ-02坐标纬度</param>
        /// <param name="mgLon">GCJ-02坐标经度</param>
        /// <param name="wgLat">输出：WGS-84坐标纬度</param>
        /// <param name="wgLon">输出：WGS-84坐标经度</param>
        public static void GCJ02ToWGS84(double mgLat, double mgLon, out double wgLat, out double wgLon)
        {
            if (OutOfChina(mgLat, mgLon))
            {
                wgLat = mgLat;
                wgLon = mgLon;
            }
            else
            {
                Delta(mgLat, mgLon, out double dLat, out double dLon);
                wgLat = mgLat - dLat;
                wgLon = mgLon - dLon;
            }
        }

        /// <summary>
        /// 火星坐标系 (GCJ-02)转WGS-84坐标系
        /// </summary>
        /// <param name="mgLat">GCJ-02坐标纬度</param>
        /// <param name="mgLon">GCJ-02坐标经度</param>
        /// <param name="wgLat">输出：WGS-84坐标纬度</param>
        /// <param name="wgLon">输出：WGS-84坐标经度</param>
        public static void GCJ02ToWGS84Exact(double mgLat, double mgLon, out double wgLat, out double wgLon)
        {
            const double InitDelta = 0.01;
            const double Threshold = 0.000001;

            double dLat = InitDelta;
            double dLon = InitDelta;
            double mLat = mgLat - dLat;
            double mLon = mgLon - dLon;
            double pLat = mgLat + dLat;
            double pLon = mgLon + dLon;

            int i = 0;
            do
            {
                wgLat = (mLat + pLat) / 2;
                wgLon = (mLon + pLon) / 2;

                WGS84ToGCJ02(wgLat, wgLon, out double nLat, out double nLon);

                dLat = nLat - mgLat;
                dLon = nLon - mgLon;
                if ((Math.Abs(dLat) < Threshold) && (Math.Abs(dLon) < Threshold)) break;

                if (dLat > 0) pLat = wgLat; else mLat = wgLat;
                if (dLon > 0) pLon = wgLon; else mLon = wgLon;
            } while (++i <= 30);
        }

        /// <summary>
        /// 百度坐标系 (BD-09)转火星坐标系 (GCJ-02)
        /// </summary>
        /// <param name="bdLat">百度坐标系纬度</param>
        /// <param name="bdLon">百度坐标系经度</param>
        /// <param name="mgLat">输出：GCJ-02坐标纬度</param>
        /// <param name="mgLon">输出：GCJ-02坐标经度</param>         
        public static void BD09ToGCJ02(double bdLat, double bdLon, out double mgLat, out double mgLon)
        {
            double x = bdLon - 0.0065;
            double y = bdLat - 0.006;
            double z = Math.Sqrt(x * x + y * y) - 0.00002 * Math.Sin(y * X_PI);
            double theta = Math.Atan2(y, x) - 0.000003 * Math.Cos(x * X_PI);
            mgLat = z * Math.Sin(theta);
            mgLon = z * Math.Cos(theta);
        }

        /// <summary>
        /// 火星坐标系 (GCJ-02)转百度坐标系 (BD-09)
        /// </summary>
        /// <param name="mgLat">GCJ-02坐标纬度</param>
        /// <param name="mgLon">GCJ-02坐标经度</param>
        /// <param name="bdLat">输出：百度坐标系纬度</param>
        /// <param name="bdLon">输出：百度坐标系经度</param>
        public static void GCJ02ToBD09(double mgLat, double mgLon, out double bdLat, out double bdLon)
        {
            double x = mgLon;
            double y = mgLat;
            double z = Math.Sqrt(x * x + y * y) + 0.00002 * Math.Sin(y * X_PI);
            double theta = Math.Atan2(y, x) + 0.000003 * Math.Cos(x * X_PI);
            bdLat = z * Math.Sin(theta) + 0.006;
            bdLon = z * Math.Cos(theta) + 0.0065;
        }

        /// <summary>
        /// WGS-84坐标系转百度坐标系 (BD-09)
        /// </summary>
        /// <param name="wgLat">WGS-84坐标纬度</param>
        /// <param name="wgLon">WGS-84坐标经度</param>
        /// <param name="bdLat">输出：百度坐标系纬度</param>
        /// <param name="bdLon">输出：百度坐标系经度</param>
        public static void WGS84ToBD09(double wgLat, double wgLon, out double bdLat, out double bdLon)
        {
            WGS84ToGCJ02(wgLat, wgLon, out double mgLat, out double mgLon);
            GCJ02ToBD09(mgLat, mgLon, out bdLat, out bdLon);
        }

        /// <summary>
        /// 百度坐标系 (BD-09)转WGS-84坐标系
        /// </summary>
        /// <param name="bdLat">百度坐标系纬度</param>
        /// <param name="bdLon">百度坐标系经度</param>
        /// <param name="wgLat">输出：WGS-84坐标纬度</param>
        /// <param name="wgLon">输出：WGS-84坐标经度</param>
        public static void BD09ToWGS84(double bdLat, double bdLon, out double wgLat, out double wgLon)
        {
            BD09ToGCJ02(bdLat, bdLon, out double mgLat, out double mgLon);
            GCJ02ToWGS84(mgLat, mgLon, out wgLat, out wgLon);
        }

        public static double Distance(double LatA, double LonA, double LatB, double LonB)
        {
            const double EarthR = 6371000.0;

            double x = Math.Cos(LatA * PI / 180.0) * Math.Cos(LatB * PI / 180.0) * Math.Cos((LonA - LonB) * PI / 180);
            double y = Math.Sin(LatA * PI / 180.0) * Math.Sin(LatB * PI / 180.0);
            double s = x + y;
            if (s > 1) s = 1;
            if (s < -1) s = -1;

            return Math.Acos(s) * EarthR;
        }

        private static void Delta(double Lat, double Lon, out double dLat, out double dLon)
        {
            const double AXIS = 6378245.0;
            const double EE = 0.00669342162296594323;

            dLat = TransformLat(Lon - 105.0, Lat - 35.0);
            dLon = TransformLon(Lon - 105.0, Lat - 35.0);
            double radLat = Lat / 180.0 * PI;
            double magic = Math.Sin(radLat);
            magic = 1 - EE * magic * magic;
            double sqrtMagic = Math.Sqrt(magic);
            dLat = (dLat * 180.0) / ((AXIS * (1 - EE)) / (magic * sqrtMagic) * PI);
            dLon = (dLon * 180.0) / (AXIS / sqrtMagic * Math.Cos(radLat) * PI);
        }

        private static double TransformLat(double x, double y)
        {
            double ret = -100.0 + 2.0 * x + 3.0 * y + 0.2 * y * y + 0.1 * x * y + 0.2 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * PI) + 20.0 * Math.Sin(2.0 * x * PI)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(y * PI) + 40.0 * Math.Sin(y / 3.0 * PI)) * 2.0 / 3.0;
            ret += (160.0 * Math.Sin(y / 12.0 * PI) + 320 * Math.Sin(y * PI / 30.0)) * 2.0 / 3.0;
            return ret;
        }

        private static double TransformLon(double x, double y)
        {
            double ret = 300.0 + x + 2.0 * y + 0.1 * x * x + 0.1 * x * y + 0.1 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * PI) + 20.0 * Math.Sin(2.0 * x * PI)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(x * PI) + 40.0 * Math.Sin(x / 3.0 * PI)) * 2.0 / 3.0;
            ret += (150.0 * Math.Sin(x / 12.0 * PI) + 300.0 * Math.Sin(x / 30.0 * PI)) * 2.0 / 3.0;
            return ret;
        }
    }
}
