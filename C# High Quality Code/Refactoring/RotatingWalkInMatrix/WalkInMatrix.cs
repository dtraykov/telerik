using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingWalkInMatrix
{
    public class WalkInMatrix
    {
        public static Cell FindEmptyCell(int[,] matrix)
        {
            Cell cell = new Cell(0, 0);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        cell.Row = row;
                        cell.Col = col;
                        return cell;
                    }
                }
            }

            return null;
        }

        public static int FillMatrix(int[,] matrix, int currentValue, Cell cell, Direction direction)
        {
            if (matrix == null || cell == null || direction == null)
            {
                throw new ArgumentNullException(
                    "Invalid input! You cannot fill matrix using empty (null) parameter.");
            }

            if (currentValue < 1)
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid input! You cannot fill matrix with non-positive number.");
            }

            matrix[cell.Row, cell.Col] = currentValue;
            while (IsPath(matrix, cell))
            {
                direction = FindDirection(matrix, cell, direction);
                cell.Row += direction.X;
                cell.Col += direction.Y;
                currentValue++;
                matrix[cell.Row, cell.Col] = currentValue;
            }

            return currentValue;
        }

        private static bool IsPath(int[,] matrix, Cell cell)
        {
            var isPath = false;
            Direction[] possibleDirections = PossibleDirection.Generate();
            UpdatePossibleDirections(possibleDirections, matrix, cell);

            for (int count = 0; count < possibleDirections.Length; count++)
            {
                int changedRow = cell.Row + possibleDirections[count].X;
                int changedColumn = cell.Col + possibleDirections[count].Y;
                if (matrix[changedRow, changedColumn] == 0)
                {
                    isPath = true;
                }
            }

            return isPath;
        }

        private static void UpdatePossibleDirections(Direction[] possibleDirections, int[,] matrix, Cell cell)
        {
            for (int count = 0; count < possibleDirections.Length; count++)
            {
                int changedRow = cell.Row + possibleDirections[count].X;
                if (changedRow >= matrix.GetLength(0) || changedRow < 0)
                {
                    possibleDirections[count].X = 0;
                }

                int changedColumn = cell.Col + possibleDirections[count].Y;
                if (changedColumn >= matrix.GetLength(0) || changedColumn < 0)
                {
                    possibleDirections[count].Y = 0;
                }
            }
        }

        private static Direction FindDirection(int[,] matrix, Cell cell, Direction direction)
        {
            int size = matrix.GetLength(0);
            bool isOuterRow = cell.Row + direction.X >= size || cell.Row + direction.X < 0;
            bool isOuterColumn = cell.Col + direction.Y >= size || cell.Col + direction.Y < 0;
            while (isOuterRow || isOuterColumn ||
                matrix[cell.Row + direction.X, cell.Col + direction.Y] != 0)
            {
                direction = PossibleDirection.GetNextPossibleDirection(direction);
                isOuterRow = cell.Row + direction.X >= size || cell.Row + direction.X < 0;
                isOuterColumn = cell.Col + direction.Y >= size || cell.Col + direction.Y < 0;
            }

            return direction;
        }
    }
}
