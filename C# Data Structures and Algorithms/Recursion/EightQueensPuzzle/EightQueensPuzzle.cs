/*
 * * Write a recursive program to solve the "8 Queens Puzzle" with backtracking.
 * Learn more at: http://en.wikipedia.org/wiki/Eight_queens_puzzle
 */

namespace EightQueensPuzzle
{
    using System;

    class EightQueensPuzzle
    {
        public static int Count = 0;

        public static void SolveQueenProblem(bool[,] board, int[,] occupied, int colIdnex)
        {
            if (colIdnex == board.GetLength(0))
            {
                Count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, colIdnex] == 0)
                {
                    board[rowIndex, colIdnex] = true;
                    MarkOccupied(occupied, +1, rowIndex, colIdnex);
                    SolveQueenProblem(board, occupied, colIdnex + 1);
                    board[rowIndex, colIdnex] = false;
                    MarkOccupied(occupied, -1, rowIndex, colIdnex);
                }
            }
        }
        public static void MarkOccupied(int[,] occupied, int value, int row, int col)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, col] += value;
                occupied[row, i] += value;

                if (col + i < occupied.GetLength(0)
                    && row + i < occupied.GetLength(0))
                {
                    occupied[row + i, col + i] += value;

                }

                if (col + i < occupied.GetLength(0) && row - i >= 0)
                {
                    occupied[row - i, col + i] += value;
                }
            }
        }

        static void Main(string[] args)
        {
            int size = 8;
            SolveQueenProblem(new bool[size, size], new int[size, size], 0);
            Console.WriteLine(Count);
        }
    }
}
