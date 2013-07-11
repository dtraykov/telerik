/*
 * Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file).
 * Print how many times each word occurs in the text.
 * Hint: you may find a C# trie in Internet.
 */

namespace WordsOccurrence
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using EeekSoft.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayWords = new string[] 
            { 
                "work",
                "normal",
                "suddenly",
                "hydrogen",
                "gold",
                "alright",
                "vacancies",
                "here",
                "always",
                "computers",
                "with",
                "hatchway",
            };

            // Create search algorithm instance
            IStringSearchAlgorithm searchAlg = new StringSearch();
            searchAlg.Keywords = arrayWords;

            StreamReader reader = new StreamReader(@"../../text.txt");
            string textToSearch;
            using (reader)
            {
                textToSearch = reader.ReadToEnd();
            }

            // Find all matching keywords  
            StringSearchResult[] results = searchAlg.FindAll(textToSearch);

            // Write all results  
            foreach (StringSearchResult r in results)
            {
                Console.WriteLine("Keyword='{0}', Index={1}", r.Keyword, r.Index);
            }
        }
    }
}
