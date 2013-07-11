/* Write a program that removes from given sequence all numbers that occur 
 * odd number of times. Example:
 * {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
 */
namespace RemoveNumbersThathOccurOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Dictionary<int, int> selection = new Dictionary<int, int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (selection.ContainsKey(sequence[i]))
                {
                    selection[sequence[i]]++;
                }
                else
                {
                    selection.Add(sequence[i], 1);
                }
            }

            List<int> occures = sequence.FindAll(x => selection[x] % 2 == 0);
            Console.Write("Elements that occur even number of times: ");
            Console.WriteLine(string.Join(", ", occures));
        }
    }
}
