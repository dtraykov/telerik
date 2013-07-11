using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingWalkInMatrix
{
    class WalkInMatrixDemo
    {
        public static void Main()
        {

            int size = ConsoleIO.ReadInput();
            int[,] matrix = new int[size, size];
            int currentValue = 1;
            Cell cell = new Cell(0, 0);
            Direction direction = PossibleDirection.GetInitialDirection();
            currentValue = WalkInMatrix.FillMatrix(matrix, currentValue, cell, direction);
            cell = WalkInMatrix.FindEmptyCell(matrix);
            if (currentValue < size * size)
            {
                currentValue++;
                direction = PossibleDirection.GetInitialDirection();
                WalkInMatrix.FillMatrix(matrix, currentValue, cell, direction);
            }

            ConsoleIO.PrintMatrix(matrix);
        }
    }
}
