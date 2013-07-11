/* Write a method that finds the longest subsequence of equal numbers in given 
 * List<int> and returns the result as new List<int>. Write a program to test 
 * whether the method works correctly.
*/
namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequence
    {
        public static List<int> FindLongestSubsequence(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentOutOfRangeException("The List has no elements.");
            }

            int equalElements = 1;
            int maxEqualElements = 1;
            int element = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    equalElements++;
                    if (equalElements > maxEqualElements)
                    {
                        maxEqualElements = equalElements;
                        element = numbers[i];
                    }
                }
                else
                {
                    equalElements = 1;
                }
            }

            List<int> result = new List<int>();
            if (maxEqualElements != 1)
            {
                for (int i = 0; i < maxEqualElements; i++)
                {
                    result.Add(element);
                }
            }
            else
            {
                element = numbers[numbers.Count - 1];
                result.Add(element);
            }

            return result;
        }

        public static List<int> ReadInput()
        {
            List<int> sequence = new List<int>();
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
                    sequence.Add(number);
                }
            }

            return sequence;
        }

        public static void Main(string[] args)
        {
            // List<int> numbers = new List<int>() { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 };
            List<int> numbers = ReadInput();
            List<int> result = FindLongestSubsequence(numbers);

            Console.Write("The longest subsequence is: ");
            foreach (var number in result)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}
