/*
 * Write a recursive program for generating and printing 
 * all permutations of the numbers 1, 2, ..., n for given integer number n. 
 * Example: n=3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
 */
namespace Permutations
{
    using System;

    class Permutations
    {
        public static void GeneratePermutation(int[] array, bool[] visited, int index)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (visited[i])
                    {
                        continue;
                    }

                    array[index] = i + 1;
                    visited[i] = true;
                    GeneratePermutation(array, visited, index + 1);
                    visited[i] = false;
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

            int[] array = new int[n];
            bool[] visited = new bool[array.Length];

            GeneratePermutation(array, visited, 0);
        }
    }
}
