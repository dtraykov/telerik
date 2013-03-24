using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculateSurface
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width)
            : this(width, 0)
        {
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Heigth should be bigger than zero!");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width should be bigger than zero!");
                }

                this.width = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
