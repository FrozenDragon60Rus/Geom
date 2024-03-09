using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom
{
    static public class Angle
    {
        public static double RadiansToDegrees(double radian) => (180f / Math.PI) * radian;
        public static double DigreesToRadians(double degree) => (Math.PI / 180f) * degree;
        public static double Get(float start, float point1, float point2)
        {
            double angle = Math.Pow(point1, 2) +
                           Math.Pow(point2, 2) -
                           Math.Pow(start, 2);
            angle /= 2 * point1 * point2;

            return Math.Acos(angle);
        }
    }
}
