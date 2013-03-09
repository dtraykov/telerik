/* 7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
 * You may need to add a generic constraints for the type T. 
 * 8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
 * 9.Implement an indexer this[row, col] to access the inner matrix cells.
 * 10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
 * Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    public class GenericMatrixTest
    {
        public static void Main(string[] args)
        {
            // Test matrix sum and substracion
            // GenericMatrix<int> firstMatrix = new GenericMatrix<int>(2, 4);
            // GenericMatrix<int> secoundMatrix = new GenericMatrix<int>(2, 4);

            // Test matrix multiplication
            GenericMatrix<int> firstMatrix = new GenericMatrix<int>(2, 4);
            GenericMatrix<int> secoundMatrix = new GenericMatrix<int>(4, 2);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    firstMatrix[row, col] = row + col + 5;
                }
            }

            for (int row = 0; row < secoundMatrix.Rows; row++)
            {
                for (int col = 0; col < secoundMatrix.Cols; col++)
                {
                    secoundMatrix[row, col] = (row * col) + 1;
                }
            }

            Console.WriteLine("First matrix Print()");
            Console.WriteLine(firstMatrix.ToString());

            Console.WriteLine("Secound matrix Print()");
            Console.WriteLine(secoundMatrix.ToString());

            // Console.WriteLine(new string('=', 80));
            // Console.WriteLine("Test matrix sum: operator +");
            // GenericMatrix<int> sum = firstMatrix + secoundMatrix;
            // Console.WriteLine(sum.ToString());

            // Console.WriteLine(new string('=', 80));
            // Console.WriteLine("Test matrix substracion: operator -");
            // GenericMatrix<int> sub = firstMatrix - secoundMatrix;
            // Console.WriteLine(sub.ToString());
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Test matrix multiplication: operator *");
            GenericMatrix<int> mult = firstMatrix * secoundMatrix;
            Console.WriteLine(mult.ToString());

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Check for non-zero elements: operators true and false");
            Console.WriteLine(firstMatrix.ToString());
            Console.WriteLine();
            if (firstMatrix)
            {
                Console.WriteLine("Matrix does not contain zero elements!");
            }
            else
            {
                Console.WriteLine("Matrix contain zero elements!");
            }
        }
    }
}
