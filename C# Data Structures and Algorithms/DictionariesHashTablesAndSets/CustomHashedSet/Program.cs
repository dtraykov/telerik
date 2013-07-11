/*
 * Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T> to hold the elements. 
 * Implement all standard set operations like Add(T), Find(T), Remove(T), Count, Clear(), union and intersect.
 */

namespace CustomHashedSet
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            CustomHashedSet<int> set = new CustomHashedSet<int>(new int[] { 111, 1, 3, 5, 7, 12 });
            Console.WriteLine(set.Count);

            set.Add(122);

            Console.WriteLine(set.Find(122));
            Console.WriteLine(set.Count);
            set.Remove(122);
            Console.WriteLine(set.Count);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            CustomHashedSet<int> newSet = new CustomHashedSet<int>(new int[] { 1, 3, 5, 7, 12, 2222 });

            newSet.UnionWhith(set);
            foreach (var item in newSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
