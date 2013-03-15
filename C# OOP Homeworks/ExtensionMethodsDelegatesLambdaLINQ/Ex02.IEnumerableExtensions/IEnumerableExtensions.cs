using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic sum = 0;

            foreach (var item in input)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic product = 1;

            foreach (var item in input)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic min = input.ElementAt(0);

            foreach (var item in input)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic max = input.ElementAt(0);

            foreach (var item in input)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic sum = 0;
            decimal counter = 0;

            foreach (var item in input)
            {
                sum += item;
                counter++;
            }

            return sum / counter;
        }
    }
}
