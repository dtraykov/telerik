/*
 * Write a program to read a large collection of products (name + price) and efficiently find the first 20 products 
 * in the price range [a…b]. Test for 500 000 products and 10 000 price searches.
 * Hint: you may use OrderedBag<T> and sub-ranges.
 */

namespace LargeCollectionOfProducts
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main(string[] args)
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            Random getrandom = new Random();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 500001; i++)
            {
                double price = getrandom.Next(1, 10000) * getrandom.Next(1, 10000) / (double)getrandom.Next(1, 10000);
                products.Add(new Product("Prod" + i, price));
            }

            stopwatch.Stop();
            Console.WriteLine("Create and add 500k Products: {0}", stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 1; i <= 10000; i++)
            {
                double minPrice = getrandom.Next(1, 10000) * getrandom.Next(1, 10000) / (double)getrandom.Next(1, 10000);
                double maxPrice = getrandom.Next(1, 10000) * getrandom.Next(1, 10000);

                var result = products.Range(new Product(minPrice), true, new Product(maxPrice), true).Take(20);
            }

            stopwatch.Stop();
            Console.WriteLine("Search for 10k random price ranges: {0}", stopwatch.Elapsed);

            Console.WriteLine("Print last 20 elements: ");
            var firstTwenty = products.Range(new Product(1), true, new Product(99980001), true).Take(20);

            foreach (var product in firstTwenty)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}