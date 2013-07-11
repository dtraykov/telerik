/*
 * * Write a program to generate all permutations with repetitions of given multi-set. 
 * For example the multi-set {1, 3, 5, 5} has the following 12 unique permutations:
 * { 1, 3, 5, 5 }   { 1, 5, 3, 5 }
 * { 1, 5, 5, 3 }   { 3, 1, 5, 5 }
 * { 3, 5, 1, 5 }   { 3, 5, 5, 1 }
 * { 5, 1, 3, 5 }   { 5, 1, 5, 3 }
 * { 5, 3, 1, 5 }   { 5, 3, 5, 1 }
 * { 5, 5, 1, 3 }   { 5, 5, 3, 1 }
 * Ensure your program efficiently avoids duplicated permutations.
 * Test it with { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }.
 */

namespace PermutationsWithRepetitions
{
    using System;
    using System.Linq;

   public class PermutationsWithRepetitions
    {
        public static void Permute(int[] subSet, int start, int n)
        {
            int tmp = 0;

            if (start < n)
            {
                for (int i = n / 2; i >= start; i--)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (subSet[i] != subSet[j])
                        {
                            // swap subSet[i] <--> subSet[j]
                            tmp = subSet[i];
                            subSet[i] = subSet[j];
                            subSet[j] = tmp;

                            Permute(subSet, i + 1, n);
                        }
                    }

                    // Undo all modifications done by
                    // recursive calls and swapping
                    tmp = subSet[i];
                    for (int k = i; k < n - 1;)
                    {
                        subSet[k] = subSet[++k];
                    }

                    subSet[n - 1] = tmp;
                }
            }

            foreach (var item in subSet)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }

       public static void Main(string[] args)
        {
            int[] multiSet = new int[] { 0, 1, 2, 3 };
            Array.Sort(multiSet);

            Permute(multiSet, 0, 4);
        }
    }
}
