using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePaths(Path currentPath, string destination)
        {
            StreamWriter saveFile = new StreamWriter(destination);
            using (saveFile)
            {
                foreach (Point3D point in currentPath.PathList)
                {
                    saveFile.WriteLine(point.ToString());
                }
            }
        }

        public static Path LoadPaths(string destination)
        {
            StreamReader loadFile = new StreamReader(destination);
            Path loadPath = new Path();
            loadPath.PathList = new List<Point3D>();
            char[] splitChars = { '[', ' ', ',', ']' };
            using (loadFile)
            {
                string line = loadFile.ReadLine();
                while (line != null)
                {
                    string[] splitedCoords = line.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                    int xcoord = int.Parse(splitedCoords[0]);
                    int ycoord = int.Parse(splitedCoords[1]);
                    int zcoord = int.Parse(splitedCoords[2]);

                    Point3D currentPoint = new Point3D(xcoord, ycoord, zcoord);
                    loadPath.PathList.Add(currentPoint);

                    line = loadFile.ReadLine();
                }
            }

            return loadPath;
        }
    }
}
