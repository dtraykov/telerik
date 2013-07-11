/*
 * Write a recursive program for generating and printing all the combinations with duplicates 
 * of k elements from n-element set. 
 * Example: n=3, k=2 -> (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
 */

namespace CombinationsWithDuplicates
{
    using System;

    public class CombinationsDuplicates
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
                    GenerateCombinations(vector, n, index + 1, i);
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
