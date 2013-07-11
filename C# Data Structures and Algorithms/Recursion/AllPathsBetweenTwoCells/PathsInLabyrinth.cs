/*
 * We are given a matrix of passable and non-passable cells.
 * Write a recursive program for finding all paths between two cells in the matrix.
 */

namespace PathBetweenTwoCellsInLargeMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PathsInLabyrinth
    {
        private static char[,] labyrinth = 
          {
              { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
              { '*', '*', ' ', '*', ' ', '*', ' ' },
              { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
              { ' ', '*', '*', '*', '*', '*', ' ' },
              { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
           };

        private static Stack<Coordinate> path = new Stack<Coordinate>();

        public static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < labyrinth.GetLength(0);
            bool colInRange = col >= 0 && col < labyrinth.GetLength(1);
            return rowInRange && colInRange;
        }

        public static void FindPathToExit(int row, int col)
        {
            if (!InRange(row, col))
            {
                return;
            }

            if (labyrinth[row, col] == 'e')
            {
                PrintPath(row, col);
            }

            if (labyrinth[row, col] != ' ')
            {
                return;
            }

            labyrinth[row, col] = 's';
            path.Push(new Coordinate(row, col));

            FindPathToExit(row, col - 1); // left
            FindPathToExit(row - 1, col); // up
            FindPathToExit(row, col + 1); // right
            FindPathToExit(row + 1, col); // down

            labyrinth[row, col] = ' ';
            path.Pop();
        }

        public static void SetExit(int row, int col)
        {
            labyrinth[row, col] = 'e';
        }

        public static void Main()
        {
            SetExit(4, 6);
            FindPathToExit(0, 0);
        }

        private static void PrintPath(int finalRow, int finalCol)
        {
            Console.Write("Found the exit: ");
            foreach (var cell in path.Reverse())
            {
                Console.Write(cell.ToString());
            }

            Console.WriteLine("({0},{1})", finalRow, finalCol);
            Console.WriteLine();
        }
    }
}
