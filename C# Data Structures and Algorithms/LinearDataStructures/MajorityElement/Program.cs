/* * The majorant of an array of size N is a value that occurs in it at least 
 * N/2 + 1 times. Write a program to find the majorant of given array (if exists). 
 * Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
 */
namespace MajorityElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void FindMajorityElement(List<int> sequence)
        {
            IDictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (numbers.ContainsKey(sequence[i]))
                {
                    numbers[sequence[i]]++;
                }
                else
                {
                    numbers.Add(sequence[i], 1);
                }
            }

            int maxOccures = numbers.Values.Max();
            int majorantFormula = (sequence.Count / 2) + 1;

            if (maxOccures >= majorantFormula)
            {
                foreach (KeyValuePair<int, int> pair in numbers)
                {
                    if (pair.Value == maxOccures)
                    {
                        Console.WriteLine("Majorant is: {0}, occures {1} times in sequence of {2} elements.", pair.Key, pair.Value, sequence.Count);
                    }
                }
            }
            else
            {
                Console.WriteLine("Majorant does not exist!");
            }
        }

        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            FindMajorityElement(sequence);
        }
    }
}
