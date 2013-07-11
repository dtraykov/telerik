/*
 * Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} 
 * and fast search by key1, key2 or by both key1 and key2.
 * Note: multiple values can be stored for given key.
 */

namespace CustomBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            BiDictionary<int, string, string> dictionary = new BiDictionary<int, string, string>();

            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i, i.ToString(), string.Format("entry{0}", i));
            }

            ICollection<string> found;

            dictionary.Add(0, "0", "duplicatedEntry0");
            found = dictionary.FindUsingFirstKey(0);
            PrintCollection<string>(found);

            dictionary.Add(1, "2", "duplicateInThreeDictionaries");
            found = dictionary.FindUsingBothKeys(1, "2");
            PrintCollection(found);

            found = dictionary.FindUsingBothKeys(5, "5");
            PrintCollection(found);

            dictionary.Add(100, "99", "only value for those keys");
            PrintCollection(dictionary.FindUsingFirstKey(100));
            PrintCollection(dictionary.FindUsingSecondKey("99"));

            dictionary.RemoveWithFirstKey(1);
            found = dictionary.FindUsingFirstKey(1);
            Console.WriteLine("Found items after removing with first key: {0}", found.Count > 0);

            dictionary.RemoveWithSecondKey("0");
            found = dictionary.FindUsingSecondKey("0");
            Console.WriteLine("Found items after removing with second key: {0}", found.Count > 0);
            found = dictionary.FindUsingFirstKey(0);
            Console.WriteLine("Found items with first key: {0}", found.Count > 0);

            dictionary.RemoveWithBothKeys(100, "99");
            found = dictionary.FindUsingBothKeys(100, "99");
            Console.WriteLine("Found items after removing with both keys: {0}", found.Count > 0);
        }

        private static void PrintCollection<V>(ICollection<V> found)
        {
            foreach (var item in found)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
        }
    }
}
