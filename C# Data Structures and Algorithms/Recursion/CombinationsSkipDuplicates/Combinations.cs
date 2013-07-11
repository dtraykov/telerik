/*
 * Modify the previous program to skip duplicates:
 * n=4, k=2 -> (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
 */

namespace CombinationsSkipDuplicates
{
    using System;

    public class Combinations
    {
        public static void GenerateCombinations(int[] vector, int n, int index, int next)
        {
            if (index == vector.Length)
            {
                Print(vector);
            }
            else
            {
                for (int i = next; i <= n; i++)
                {
                    vector[index] = i;
                    GenerateCombinations(vector, n, index + 1, i + 1);
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

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            int[] vector = new int[k];

            GenerateCombinations(vector, n, 0, 1);
        }
    }
}
