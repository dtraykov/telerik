/*
 * Modify the above program to check whether a path exists 
 * between two cells without finding all possible paths. 
 * Test it over an empty 100 x 100 matrix.
 */

namespace PathBetweenTwoCellsInLargeMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PathInLargeLabyrinth
    {
        private static char[,] labyrinth;

        private static Stack<Coordinate> path = new Stack<Coordinate>();

        public static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < labyrinth.GetLength(0);
            bool colInRange = col >= 0 && col < labyrinth.GetLength(1);
            return rowInRange && colInRange;
        }

        public static void FindPathToExit(int row, int col, ref bool found)
        {
            if (found)
            {
                return; 
            }

            if (!InRange(row, col))
            {
                return;
            }

            if (labyrinth[row, col] == 'e')
            {
                PrintPath(row, col);
                found = true;
            }

            if (labyrinth[row, col] != ' ')
            {
                return;
            }

            labyrinth[row, col] = 's';
            path.Push(new Coordinate(row, col));

            FindPathToExit(row, col - 1, ref  found); // left
            FindPathToExit(row - 1, col, ref  found); // up
            FindPathToExit(row, col + 1, ref  found); // right
            FindPathToExit(row + 1, col, ref  found); // down

            labyrinth[row, col] = ' ';
            path.Pop();
        }

        public static void SetExit(int row, int col)
        {
            labyrinth[row, col] = 'e';
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

        public static void Main()
        {
            int size = 100;
            labyrinth = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    labyrinth[row, col] = ' ';
                }
            }

            SetExit(size - 1, size - 1);
            bool found = false;
            FindPathToExit(0, 0, ref  found);
        }
    }
}
