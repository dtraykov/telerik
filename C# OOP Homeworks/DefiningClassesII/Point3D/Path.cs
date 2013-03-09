using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        private List<Point3D> pathList = new List<Point3D>();

        public List<Point3D> PathList
        {
            get { return this.pathList; }
            set { this.pathList = value; }
        }
    }
}
