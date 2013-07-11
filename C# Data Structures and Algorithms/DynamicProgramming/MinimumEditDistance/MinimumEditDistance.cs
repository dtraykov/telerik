/*
 * Write a program to calculate the "Minimum Edit Distance" (MED) between two words. 
 * MED(x, y) is the minimal sum of costs of edit operations used to transform x to y.
 * Sample costs are given below:
 * cost (replace a letter) = 1
 * cost (delete a letter) = 0.9
 * cost (insert a letter) = 0.8
 * Example: x = "developer", y = "enveloped" -> cost = 2.7 
 * delete ‘d’:  "developer" -> "eveloper", cost = 0.9
 * insert ‘n’:  "eveloper" -> "enveloper", cost = 0.8
 * replace ‘r’ -> ‘d’:  "enveloper" -> "enveloped", cost = 1
 */

namespace MinimumEditDistance
{
    using System;
    using System.Linq;

    public class MinimumEditDistance
    {
        private const decimal CostDelete = 0.9m;
        private const decimal CostInsert = 0.8m;
        private const decimal CostReplace = 1.0m;

        public static void Main(string[] args)
        {
            decimal med = EditDistanceRecursive("developer", "enveloped", 0, 0);
            Console.WriteLine(med);
        }

        public static decimal EditDistanceRecursive(string pattern, string input, int pp = 0, int pi = 0)
        {
            if (pp == pattern.Length && pi == pattern.Length)
            {
                return 0;
            }

            decimal minCostPi = decimal.MaxValue;
            decimal minCost2 = decimal.MaxValue;
            decimal minCostPp = decimal.MaxValue;

            if (pi < input.Length)
            {
                minCostPi = CostDelete + EditDistanceRecursive(pattern, input, pp, pi + 1);
            }

            if (pi < input.Length && pp < input.Length)
            {
                minCost2 = (pattern[pp] == input[pi] ? 0 : CostReplace) +
                                EditDistanceRecursive(pattern, input, pp + 1, pi + 1);
            }

            if (pp < pattern.Length)
            {
                minCostPp = CostInsert + EditDistanceRecursive(pattern, input, pp + 1, pi);
            }

            return Math.Min(minCostPi, Math.Min(minCost2, minCostPp));
        }

        public static decimal EditDistanceDynamic(string pattern, string input)
        {
            decimal[,] table = new decimal[2, input.Length + 1];

            for (int pi = 1; pi <= input.Length; ++pi)
            {
                table[0, pi] = pi * CostDelete;
            }

            int pp;
            for (pp = 1; pp <= pattern.Length; ++pp)
            {
                int thisRow = pp % 2;
                int prevRow = 1 - thisRow;

                table[thisRow, 0] = pp * CostInsert;

                for (int pi = 1; pi <= input.Length; ++pi)
                {
                    decimal cost = (input[pi - 1] == pattern[pp - 1]) ? 0 : CostReplace;

                    decimal minCostPi = table[thisRow, pi - 1] + CostDelete;
                    decimal minCost2 = table[prevRow, pi - 1] + cost;
                    decimal minCostPp = table[prevRow, pi] + CostInsert;

                    table[thisRow, pi] = Math.Min(Math.Min(minCostPp, minCostPi), minCost2);
                }
            }

            return table[1 - (pp % 2), input.Length];
        }
    }
}
