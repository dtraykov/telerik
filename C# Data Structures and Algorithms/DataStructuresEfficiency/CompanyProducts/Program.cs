/* A large trade company has millions of articles, each described by barcode, vendor, title and price. 
 * Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y]. 
 * Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET. 
 */

namespace CompanyProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
                {
                   new Product("565466756", "ASROCK K7S41GX2 /SIS741GX", "MAIN BOARD"),
                   new Product("565466757", "GB H61M-USB3V /1155", "MAIN BOARD"),
                   new Product("565466758", "ASUS F2A85-M LE /FM2", "MAIN BOARD"),
                   new Product("565466759", "I3-3220T 2.8GHZ/3M/LGA1155/BOX", "CPU"),
                   new Product("565466760", "I7-4770 /3.4G/8MB/BOX/LGA1150", "CPU"),
                   new Product("565466761", "AMD FX-4350 /4.2GZ/X4/BOX/AM3+", "CPU"),
                   new Product("565466762", "8G DDR3 1600 ECC KINGSTON", "RAM"),
                   new Product("565466763", "8G DDR3 1600 GEIL EVO CORSA", "RAM"),
                   new Product("565466764", "4X8G DDR3 1600 GEIL EVO LEGGER", "RAM"),
                };

            List<double> price = new List<double>()
                {
                   85.19, 85.19, 132.19, 196.81, 486.15, 196.81, 99.58, 99.58, 403.46,
                };

            OrderedMultiDictionary<double, Product> companyProducts =
                new OrderedMultiDictionary<double, Product>(true);

            for (int i = 0; i < products.Count; i++)
            {
                companyProducts.Add(price[i], products[i]);
            }

            Console.WriteLine("Price range: from 60.0 to 120.5");
            var productsInRange = companyProducts.Range(60.0, true, 120.5, true);
            foreach (var item in productsInRange)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.ToString());
            }
        }
    }
}
