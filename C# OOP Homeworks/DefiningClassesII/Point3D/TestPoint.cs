/*1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
 * Implement the ToString() to enable printing a 3D point.
 *2. Add a private static read-only field to hold the start of the coordinate system – 
 * the point O{0, 0, 0}. Add a static property to return the point O.
 *3. Write a static class with a static method to calculate the distance between two points in the 3D space.
 *4. Create a class Path to hold a sequence of points in the 3D space. 
 * Create a static class PathStorage with static methods to save and load paths from a text file.
 * Use a file format of your choice.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class TestPoint
    {
        public static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(2, 3, 4);
            Console.WriteLine(firstPoint.ToString());
            Console.WriteLine(Point3D.О.ToString());

            Console.WriteLine("The distance between Point{0} and Point{1} is: {2}", firstPoint.ToString(), Point3D.О.ToString(), CalculateDistance.ThrеePoint(firstPoint, Point3D.О));

            Path currentPath = new Path();
            currentPath.PathList = new List<Point3D>();
            currentPath.PathList.Add(new Point3D(3, 4, 5));
            currentPath.PathList.Add(new Point3D(5, 6, 1));
            currentPath.PathList.Add(new Point3D(7, 9, 2));
            currentPath.PathList.Add(new Point3D(9, 7, 0));
            currentPath.PathList.Add(new Point3D(2, 3, 5));
            currentPath.PathList.Add(new Point3D(1, 5, 1));
            currentPath.PathList.Add(Point3D.О);

            string destination = @"../../paths.txt";
            PathStorage.SavePaths(currentPath, destination);
            Console.WriteLine();
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Save paths... in paths.txt");
            Path loadedPath = new Path();
            loadedPath = PathStorage.LoadPaths(destination);
            Console.WriteLine("Load and print paths from paths.txt");
            foreach (var point in loadedPath.PathList)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
