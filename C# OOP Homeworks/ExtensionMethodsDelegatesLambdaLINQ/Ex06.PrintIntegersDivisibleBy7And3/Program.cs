/* 6.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
 *Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.PrintIntegersDivisibleBy7And3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[100];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var divisibleLambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0);

            Console.WriteLine("Numbers that are divisible by 7 and 3. Using lambda:");
            foreach (var item in divisibleLambda)
            {
                Console.WriteLine(item);
            }

            var divisibleLinq =
                from div in numbers
                where div % 3 == 0 && div % 7 == 0
                select div;

            Console.WriteLine("Numbers that are divisible by 7 and 3. Using LINQ:");
            foreach (var item in divisibleLinq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
