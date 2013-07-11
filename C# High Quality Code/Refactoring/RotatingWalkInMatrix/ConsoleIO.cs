using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingWalkInMatrix
{
    public class ConsoleIO
    {
        private const int MinSize = 1;
        private const int MaxSize = 100;

        public static int ReadInput()
        {
            Console.WriteLine(
                "Enter a positive number in the interval [{0}, {1}]", MinSize, MaxSize);
            int size = 0;
            string input = Console.ReadLine();
            bool inputIsNumber = int.TryParse(input, out size);
            while (!inputIsNumber || size < MinSize || size > MaxSize)
            {
                Console.WriteLine("You entered a incorrect number");
                input = Console.ReadLine();
                inputIsNumber = int.TryParse(input, out size);
            }

            return size;
        }

        public static string PrintMatrix(int[,] matrix)
        {
            StringBuilder matrixString = new StringBuilder();
            int size = matrix.GetLength(0);
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    matrixString.Append(string.Format("{0,3}", matrix[row, column]));
                }

                matrixString.AppendLine();
            }

            Console.WriteLine(matrixString.ToString());
            return matrixString.ToString();
        }
    }
}
