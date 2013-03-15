/* 1.Implement an extension method Substring(int index, int length) for the class StringBuilder 
 * that returns new StringBuilder and has the same functionality as Substring in the class String.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    public class SubstringTest
    {
        public static void Main(string[] args)
        {
            StringBuilder substringTest = new StringBuilder();
            substringTest.Append("Hello c#!");

            Console.WriteLine(substringTest.Substring(6, 3).ToString());
        }
    }
}
