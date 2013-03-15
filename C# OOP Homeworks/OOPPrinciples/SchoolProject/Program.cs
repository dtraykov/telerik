using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students1 = new List<Student>();

            students1.Add(new Student("Goshu", "Goshuv", 1));
            students1.Add(new Student("Cecka", "Cacheva", 2));
            students1.Add(new Student("Peshu", "Peshuv", 3));
            students1.Add(new Student("Ivan", "Ivanov", 4));
            students1.Add(new Student("Mariika", "Mariikova", 5));
            students1.Add(new Student("Zelka", "Morkovkova", 6));
            students1.Add(new Student("Akaciq", "Trendafilova", 7));

            List<Student> students2 = new List<Student>();

            students2.Add(new Student("Pupesh", "Emilov", 1));
            students2.Add(new Student("Mariika", "Mariikova", 2));
            students2.Add(new Student("Zelka", "Morkovkova", 3));
            students2.Add(new Student("Goshu", "Goshuv", 4));
            students2.Add(new Student("Cecka", "Cacheva", 5));
            students2.Add(new Student("Akaciq", "Trendafilova", 6));
            students2.Add(new Student("Peshu", "Peshuv", 7));

            List<Disciplines> donchoMinkovCourses = new List<Disciplines>();

            donchoMinkovCourses.Add(new Disciplines("C# Fundamentals Part I", 8, 8));
            donchoMinkovCourses.Add(new Disciplines("C# Fundamentals Part II", 8, 8));
            donchoMinkovCourses.Add(new Disciplines("Object-Oriented Programming", 8, 8));
            donchoMinkovCourses.Add(new Disciplines("JavaScript Part I", 8, 8));

            List<Disciplines> nikolayKostovCourses = new List<Disciplines>();

            nikolayKostovCourses.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            nikolayKostovCourses.Add(new Disciplines("C# Fundamentals Part II", 5, 5));
            nikolayKostovCourses.Add(new Disciplines("Object-Oriented Programming", 9, 9));
            nikolayKostovCourses.Add(new Disciplines("ASP.NET MVC", 8, 8));

            List<Disciplines> georgeGeorgievCourses = new List<Disciplines>();

            georgeGeorgievCourses.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            georgeGeorgievCourses.Add(new Disciplines("C# Fundamentals Part II", 5, 5));
            georgeGeorgievCourses.Add(new Disciplines("HTML5", 9, 9));
            georgeGeorgievCourses.Add(new Disciplines("CSS3", 8, 8));

            List<Disciplines> svetlinNakovCourses = new List<Disciplines>();

            svetlinNakovCourses.Add(new Disciplines("C# Fundamentals Part I", 10, 10));
            svetlinNakovCourses.Add(new Disciplines("C# Fundamentals Part II", 18, 3));
            svetlinNakovCourses.Add(new Disciplines("Object-Oriented Programming", 8, 1));
            svetlinNakovCourses.Add(new Disciplines("Knowledge Sharing and Teamwork", 10, 0));

            List<Teacher> teachers1 = new List<Teacher>();

            teachers1.Add(new Teacher("Doncho", "Minkov", donchoMinkovCourses));
            teachers1.Add(new Teacher("Nikolay", "Kostov", nikolayKostovCourses));

            List<Teacher> teachers2 = new List<Teacher>();

            teachers2.Add(new Teacher("George", "Georgiev", georgeGeorgievCourses));
            teachers2.Add(new Teacher("Svetlin", "Nakov", svetlinNakovCourses));

            List<SchoolClass> schoolClasses = new List<SchoolClass>();

            schoolClasses.Add(new SchoolClass("Ia", students1, teachers1));
            schoolClasses.Add(new SchoolClass("Ib", students2, teachers2));

            School telerikAcademy = new School("Telerik Academy", schoolClasses);

            Console.WriteLine(telerikAcademy);
        }
    }
}
