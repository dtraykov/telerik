using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        public int X;

        public int Y;

        public int Z;

        private static readonly Point3D Origo = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D О 
        {
            get { return Origo; }
        }
        
        public override string ToString()
        {
            string point = string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
            return point;
        }
    }
}
