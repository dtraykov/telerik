/*
 * Write a program that counts in a given array of double values the number of occurrences of each value. 
 * Use Dictionary<TKey,TValue>.
 * Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
 * -2.5 -> 2 times
 * 3 -> 4 times
 * 4 -> 3 times
 */

namespace CountsNumberOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<float> numbers = new List<float>() { 3, 4, 4, -2.5f, 3, 3, 4, 3, -2.5f };

            IDictionary<float, int> numberOfOccurrences = CalculateNumberOfOccurrences(numbers);

            foreach (var pair in numberOfOccurrences)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }

        private static IDictionary<float, int> CalculateNumberOfOccurrences(List<float> numbers)
        {
            IDictionary<float, int> numberOfOccurrences = new SortedDictionary<float, int>();

            foreach (var number in numbers)
            {
                if (numberOfOccurrences.ContainsKey(number))
                {
                    numberOfOccurrences[number]++;
                }
                else
                {
                    numberOfOccurrences.Add(number, 1);
                }
            }

            return numberOfOccurrences;
        }
    }
}
