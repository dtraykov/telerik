/* 5.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
 * clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
 * 6.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            // Declare a list of type int 
            GenericList<int> intList = new GenericList<int>();
            intList.Add(13);
            intList.Add(36);
            intList.Add(52);
            intList.Add(9);
            intList.Add(18);

            Console.WriteLine("Testing ToString()");
            Console.WriteLine(intList.ToString());

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Testing indexator: 3");
            Console.WriteLine(intList[3]);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Testing remove by index: 3");
            intList.RemoveAt(3);
            Console.WriteLine(intList.ToString());

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Testing insert by index: 2 , value: 19");
            intList.Insert(2, 19);
            Console.WriteLine(intList.ToString());

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Testing find element value: 19");
            Console.WriteLine(intList.Find(19));

            Console.WriteLine(new string('=', 80));
            int max = intList.Max();
            int min = intList.Min();
            Console.WriteLine("Testing min and max");
            Console.WriteLine("Min: {0}, Max: {1}", min, max);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Testing clear");
            intList.Clear();
            Console.WriteLine("Number of elements: {0}", intList.Count);

            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("C#");
            stringList.Add("Java");
            stringList.Add("PHP");
            stringList.Add("SQL");

            Console.WriteLine(new string('=', 80)); 
            Console.WriteLine("Testing ToString()");
            Console.WriteLine(stringList.ToString());
            string maxString = stringList.Max();
            string minString = stringList.Min();

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Testing min and max");
            Console.WriteLine("Min: {0}, Max: {1}", minString, maxString);
        }
    }
}
