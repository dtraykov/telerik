/* 3.Write a method that from a given array of students finds all students whose first name is before its 
 * last name alphabetically. Use LINQ query operators.
 * 4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 * 5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name 
 * and last name in descending order. Rewrite the same with LINQ.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.FindStudentsFirstNameBeforeLast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = 
            { 
               new Student("Pesho", "Ivanov", 22),
               new Student("Denislav", "Jordanov", 30),
               new Student("Anna", "Vasileva", 15),
               new Student("Mariq", "Gecova", 19),
               new Student("Linda", "Atanasova", 42) 
             };

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Finds all students whose first name is before its last name alphabetically:");
            Student.FirstBeforeLast(students);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Finds the first name and last name of all students with age between 18 and 24:");
            Student.AgeRestriction(students);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Lambda sort the students by first name and last name in descending order:");
            Student.SortByNameLambda(students);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("LINQ sort the students by first name and last name in descending order:");
            Student.SortByNameLinq(students);
        }
    }
}
