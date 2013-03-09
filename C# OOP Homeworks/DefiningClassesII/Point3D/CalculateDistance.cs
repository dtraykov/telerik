using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class CalculateDistance
    {
        public static double ThrеePoint(Point3D firstPoint, Point3D secoundPoint)
        {
            double distance = Math.Sqrt(Math.Pow(firstPoint.X - secoundPoint.X, 2) +
                                        Math.Pow(firstPoint.Y - secoundPoint.Y, 2) +
                                        Math.Pow(firstPoint.Z - secoundPoint.Z, 2));
            return distance;
        }
    }
}
