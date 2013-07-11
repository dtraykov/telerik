/*
 * Write a program for generating and printing all subsets of k strings from given set of strings.
 * Example: s = {test, rock, fun}, k=2
 * (test rock),  (test fun),  (rock fun)
 */

namespace SubsetsOfKStrings
{
    using System;

    class SubsetsOfKStrings
    {
        public static void Subsets(string[] subsets, string[] set, int n, int index, int next)
        {
            if (index == subsets.Length)
            {
                Print(subsets);
            }
            else
            {
                for (int i = next; i <= n; i++)
                {
                    subsets[index] = set[i];
                    Subsets(subsets, set, n, index + 1, i + 1);
                }
            }
        }

        public static void Print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            string[] subsets = new string[n];
            string[] set = new string[] { "test", "rock", "fun" };

            Subsets(subsets, set, n, 0, 0);
        }
    }
}
