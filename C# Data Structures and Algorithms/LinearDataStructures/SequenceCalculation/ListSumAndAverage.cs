/*Write a program that reads from the console a sequence of positive integer numbers.
 * The sequence ends when empty line is entered. Calculate and print the sum and 
 * average of the elements of the sequence. Keep the sequence in List<int>.
*/
namespace SequenceCalculation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListSumAndAverage
    {
        public static List<int> ReadInput()
        {
            List<int> numbers = new List<int>();
            bool isValidNumber = true;

            while (isValidNumber)
            {
                string inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    isValidNumber = false;
                }
                else
                {
                    int number = int.Parse(inputLine);
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        public static void Main(string[] args)
        {
            List<int> numbers = ReadInput();

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}
