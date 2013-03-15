/* 2.Define abstract class Human with first name and last name. Define new class Student which is 
 * derived from Human and has new field – grade. Define class Worker derived from Human with 
 * new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned 
 * by hour by the worker. Define the proper constructors and properties for this hierarchy. 
 * Initialize a list of 10 students and sort them by grade in ascending order 
 * (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour 
 * in descending order. Merge the lists and sort them by first name and last name.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Goshu", "Goshuv", 2f));
            students.Add(new Student("Cecka", "Cacheva", 4.5f));
            students.Add(new Student("Peshu", "Peshuv", 3f));
            students.Add(new Student("Ivan", "Ivanov", 6f));
            students.Add(new Student("Mariika", "Mariikova", 5f));
            students.Add(new Student("Zelka", "Morkovkova", 6f));
            students.Add(new Student("Akaciq", "Trendafilova", 4.5f));
            students.Add(new Student("Pupesh", "Emilov", 4f));
            students.Add(new Student("Ginka", "Emilova", 2f));

            students = students.OrderBy(student => student.Grade).ToList();
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Students sorted by grade in ascending order:");
            Console.WriteLine(new string('=', 80));

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Zelka", "Doncheva", 200));
            workers.Add(new Worker("Pupesh", "Dimitrov"));
            workers.Add(new Worker("Yordan", "Nikolov", 500, 12));
            workers.Add(new Worker("Boris", "Kovachev", 350));
            workers.Add(new Worker("Akaciq", "Ivanova", 280, 4));
            workers.Add(new Worker("Vladimir", "Georgiev", 400));
            workers.Add(new Worker("Lina", "Cacheva", 380));
            workers.Add(new Worker("Mihail", "Petrov", 275));
            workers.Add(new Worker("Martin", "Yanchev", 350, 12));
            workers.Add(new Worker("Mariika", "Mihaylova", 295));

            workers =
                     (from worker in workers
                      orderby worker.MoneyPerHour() descending
                      select worker).ToList();

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Workers sorted by money per hour in descending order:");
            Console.WriteLine(new string('=', 80));

            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }

            var meragedLists = students.Concat<Human>(workers).ToList();
            meragedLists = meragedLists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Merged lists and sorted by first name and last name:");
            Console.WriteLine(new string('=', 80));

            foreach (var item in meragedLists)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
