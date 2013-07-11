namespace Ex1.FigureRotation
{
    using System;

    public class FigureSize
    {
        private double width;
        private double height;

        public FigureSize(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
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
                this.width = value;
            }
        }

        public static FigureSize GetRotatedSize(FigureSize initialSize, double angleOfRotating)
        {
            double newCosWidthSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.Width;
            double newSinHeightSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.Height;
            double newSinWidthSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.Width;
            double newCosHeightSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.Height;
            double fullWidthSize = newCosWidthSize + newSinWidthSize;
            double fullHeightSize = newCosHeightSize + newSinHeightSize;
            FigureSize newSize = new FigureSize(fullWidthSize, fullHeightSize);

            return newSize;
        }
    }
}
