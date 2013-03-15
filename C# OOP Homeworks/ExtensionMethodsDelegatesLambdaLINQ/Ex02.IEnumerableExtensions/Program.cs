/* 2.Implement a set of extension methods for IEnumerable<T> that implement 
 * the following group functions: sum, product, min, max, average.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.IEnumerableExtensions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(new string('=', 80));
            foreach (var item in intElements)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("Sum of elements: {0}", intElements.Sum());
            Console.WriteLine("Product of elements: {0}", intElements.Product());
            Console.WriteLine("Max of elements: {0}", intElements.Max());
            Console.WriteLine("Min of elements: {0}", intElements.Min());
            Console.WriteLine("Average of elements: {0}", intElements.Average());

            Console.WriteLine(new string('=', 80));
            string[] stringElements = { "Anna", "Pesho", "Goshu", "Cecka" };
            foreach (var item in stringElements)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("Max of elements: {0}", stringElements.Max());
            Console.WriteLine("Min of elements: {0}", stringElements.Min());
        }
    }
}
