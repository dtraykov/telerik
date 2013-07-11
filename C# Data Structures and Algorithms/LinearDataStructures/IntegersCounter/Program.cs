/* Write a program that finds in given array of integers 
 * (all belonging to the range [0..1000]) how many times each of them occurs.
 * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
 * 2 -> 2 times
 * 3 -> 4 times
 * 4 -> 3 times
*/
namespace IntegersCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static IDictionary<int, int> FindHowManyTimesOccur(int[] array)
        {
            IDictionary<int, int> numberOfOccuran = new SortedDictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (numberOfOccuran.ContainsKey(array[i]))
                {
                    numberOfOccuran[array[i]]++;
                }
                else
                {
                    numberOfOccuran.Add(array[i], 1);
                }
            }

            return numberOfOccuran;
        }

        public static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            IDictionary<int, int> numberOfOccuran = FindHowManyTimesOccur(array);

            foreach (var item in numberOfOccuran)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
