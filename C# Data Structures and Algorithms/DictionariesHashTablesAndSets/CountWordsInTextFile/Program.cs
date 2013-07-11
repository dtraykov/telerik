/*
 * Write a program that counts how many times each word from given text file words.txt appears in it. 
 * The character casing differences should be ignored. The result words should be ordered by their number 
 * of occurrences in the text. 
 * Example: This is the TEXT. Text, text, text - THIS TEXT! Is this the text?
 * is -> 2
 * the -> 2
 * this -> 3
 * text -> 6
*/

namespace CountWordsInTextFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"../../words.txt";
            string text = ReadTextFile(path);
            string[] words = text.ToLower().Split(
                new char[] { ' ', ',', '.', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            IDictionary<string, int> numberOfOccurrences = CalculateNumberOfOccurrences(words);

            var orderByValue = numberOfOccurrences.OrderBy(x => x.Value);

            foreach (var pair in orderByValue)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }

        private static string ReadTextFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            string text;

            using (reader)
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        private static IDictionary<string, int> CalculateNumberOfOccurrences(string[] words)
        {
            IDictionary<string, int> numberOfOccurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (numberOfOccurrences.ContainsKey(word))
                {
                    numberOfOccurrences[word]++;
                }
                else
                {
                    numberOfOccurrences.Add(word, 1);
                }
            }

            return numberOfOccurrences;
        }
    }
}
