/*
 * Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
 * {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
 */
namespace ExtractOddElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> elements = new List<string>() { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            IDictionary<string, int> numberOfOccurrences = CalculateNumberOfOccurrences(elements);

            foreach (var pair in numberOfOccurrences)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }

            Console.WriteLine();
        }

        private static IDictionary<string, int> CalculateNumberOfOccurrences(List<string> elements)
        {
            IDictionary<string, int> numberOfOccurrences = new Dictionary<string, int>();

            foreach (var element in elements)
            {
                if (numberOfOccurrences.ContainsKey(element))
                {
                    numberOfOccurrences[element]++;
                }
                else
                {
                    numberOfOccurrences.Add(element, 1);
                }
            }

            return numberOfOccurrences;
        }
    }
}
