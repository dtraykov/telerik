/* Write a program that reads N integers from the console and reverses 
 * them using a stack. Use the Stack<int> class.
 */

namespace StackReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number[{0}]: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                numbers.Push(number);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
