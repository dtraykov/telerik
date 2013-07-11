namespace PathBetweenTwoCellsInLargeMatrix
{
    using System;

    public struct Coordinate
    {
        public Coordinate(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;

            set;
        }

        public int Y
        {
            get;

            set;
        }

        public override string ToString()
        {
            return string.Format("({0},{1}) -> ", this.X, this.Y);
        }
    }
}
