﻿using System;

namespace RotatingWalkInMatrix
{
    public class Direction
    {
        public Direction(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
