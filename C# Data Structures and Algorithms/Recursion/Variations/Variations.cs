/*
 * Write a recursive program for generating and printing all ordered 
 * k-element subsets from n-element set (variations Vkn).
 * Example: n=3, k=2, set = {hi, a, b} =>
 * (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
 */

namespace Variations
{
    using System;

    public class Variations
    {
        public static void Variation(string[] array, string[] set, int n, int index)
        {
            if (index == array.Length)
            {
                PrintVariations(array);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    array[index] = set[i];
                    Variation(array, set, n, index + 1);
                }
            }
        }

        public static void PrintVariations(string[] array)
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

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            string[] array = new string[k];
            string[] set = new string[] { "hi", "a", "b" };

            Variation(array, set, n, 0);
        }
    }
}
