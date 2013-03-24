using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculateSurface
{
    public class TestShapes
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Triangle(10, 5);
            shapes[1] = new Rectangle(4, 6);
            shapes[2] = new Circle(5);

            foreach (var shape in shapes)
            {
                Console.WriteLine("The surface of {0} is {1:F2}.", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
