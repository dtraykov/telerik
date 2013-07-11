/* Write a program that removes from given sequence all negative numbers.
 */
namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(-5);
            numbers.Add(-3);
            numbers.Add(-2);
            numbers.Add(1);
            numbers.Add(0);
            numbers.Add(4);

            List<int> positiveNumbers = new List<int>();
            positiveNumbers = numbers.FindAll(x => x >= 0);

            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
