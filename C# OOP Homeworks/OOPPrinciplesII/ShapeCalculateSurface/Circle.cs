using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculateSurface
{
    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width * Math.PI;
        }
    }
}