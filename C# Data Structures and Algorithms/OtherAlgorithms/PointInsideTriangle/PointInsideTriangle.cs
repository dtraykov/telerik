/* barycentric coordinates of pt 4
 * see http://en.wikipedia.org/wiki/Barycentric_coordinate_system
 * there are at least four more ways to solve the problem
 * check if the point is in the same half plane relative to each side as the barycenter, using vector cross products
 * check if the angles from the point to each pair of vertices sum to 360
 * check if the areas between the point and each pair of vertices sum to the area of the triangle 
 * check if the line segments from the point to each vertex cross the opposite side
 * I personally would either use this solution or the cross product one
*/
namespace PointInsideTriangle
{
    using System;
    using System.Linq;
    using System.IO;

    class PointInsideTriangle
    {
        static void Main(string[] args)
        {
            string input = null;

           input = "1.0 1.0|2.0 3.0|3.0 2.0|2.0 2.0";

            // no
            // input = "1.0 1.0|2.0 3.0|3.0 2.0|0.0 0.0";

            if (input != null)
            {
                Console.SetIn(new StringReader(input.Replace(" ", "\n").Replace("|", "\n")));
            }

            var cordX1 = double.Parse(Console.ReadLine());
            var cordY1 = double.Parse(Console.ReadLine());
            var cordX2 = double.Parse(Console.ReadLine());
            var cordY2 = double.Parse(Console.ReadLine());
            var cordX3 = double.Parse(Console.ReadLine());
            var cordY3 = double.Parse(Console.ReadLine());

            var cordX4 = double.Parse(Console.ReadLine());
            var cordY4 = double.Parse(Console.ReadLine());

            double dx = (cordX4 - cordX3);
            double dy = (cordY4 - cordY3);

            double pointA = cordX1 - cordX3;
            double pointB = cordY1 - cordY3;
            double pointC = cordX2 - cordX3;
            double pointD = cordY2 - cordY3;

            double denom = pointA * pointD - pointB * pointC;

            double alpha = pointD * dx - pointC * dy;
            alpha /= denom;
             
            double beta = -pointB * dx + pointA * dy;
            beta /= denom;

            double gamma = 1.0 - (alpha + beta);

            if (alpha >= 0 && beta >= 0 && gamma >= 0)
            {
                Console.WriteLine("Point lies inside the triangle.");
            }
            else
            {
                Console.WriteLine("Point lies outside the triangle.");
            }
        }
    }
}