/* 5.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
 * Override ToString() to display the information of a person and if age is not specified – to say so. 
 * Write a program to test this functionality.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4.Person
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person firstPerson = new Person("Ivan");
            Person secoundPerson = new Person("Goshu", 26);
            Person thirdPerson = new Person("Peshu", null);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secoundPerson);
            Console.WriteLine(thirdPerson);
        }
    }
}
