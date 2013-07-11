/*
 * Write a recursive program that simulates the execution of n nested loops from 1 to n.
 */

namespace NestedLoops
{
    using System;

    public class VectorsGenerator
    {
        public static void GenerateCombinations(int[] vector, int index, int n)
        {
            if (index >= vector.Length)
            {
                Print(vector);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    vector[index] = i;

                    GenerateCombinations(vector, index + 1, n);
                }
            }
        }

        public static void Print(int[] vector)
        {
            foreach (int i in vector)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            GenerateCombinations(vector, 0, n);
        }
    }
}
