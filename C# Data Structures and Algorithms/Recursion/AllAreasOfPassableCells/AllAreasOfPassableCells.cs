/*
 * * We are given a matrix of passable and non-passable cells.
 * Write a recursive program for finding all areas of passable cells in the matrix.
 */

namespace AllAreasOfPassableCells
{
    using System;

    public class AllAreasOfPassableCells
    {
        private static string[,] labyrinth = 
        {
            { " ", " ", " ", "*", " ", " ", " " },
            { "*", "*", " ", "*", " ", "*", " " },
            { " ", " ", " ", "*", " ", " ", " " },
            { " ", "*", "*", "*", "*", "*", "*" },
            { " ", " ", " ", "*", " ", " ", " " },
        };

        public static void Main(string[] args)
        {
            FindBiggestArea(labyrinth.GetLength(0), labyrinth.GetLength(1));
        }

        public static void FindBiggestArea(int rows, int cols)
        {
            int number = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (labyrinth[i, j] == " ")
                    {
                        FindArea(i, j, number);
                        PrintLabyrint(number.ToString());
                        number++;
                    }
                }
            }
        }

        public static void FindArea(int row, int col, int number)
        {
            if (row < 0 || col < 0 ||
                row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = number.ToString();

            FindArea(row, col - 1, number);
            FindArea(row - 1, col, number);
            FindArea(row, col + 1, number);
            FindArea(row + 1, col, number);
        }

        public static void PrintLabyrint(string number)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == number || labyrinth[i, j] == "*")
                    {
                        Console.Write("{0, 2} ", labyrinth[i, j]);
                    }
                    else
                    {
                        Console.Write("{0, 2} ", " ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}