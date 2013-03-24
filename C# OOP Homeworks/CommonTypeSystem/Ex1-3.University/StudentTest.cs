/* 1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
 * mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
 * Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 * 3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
 * and by social security number (as second criteria, in increasing order).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_3.University
{
    public class StudentTest
    {
        public static void Main(string[] args)
        {
            Student firstStudent = new Student(
                "Petur",
                "Petrov",
                "Petrov",
                12345,
                "str. Al. Malinov",
                08888888,
                "pesho@gmail.com",
                2,
                University.SofiaUniversity,
                Faculty.PhysicsFaculty,
                Specialty.Mathematics);

            Student secoundStudent = new Student(
               "Goshu",
               "Goshuv",
               "Goshuv",
               67890,
               "str. Al. Malinov",
               08888888,
               "goshu@gmail.com",
               3,
               University.TechnicalUniversity,
               Faculty.MathematicsAndInformaticsFaculty,
               Specialty.Informatics);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("First Student");
            Console.WriteLine(firstStudent.ToString());

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Secound Student");
            Console.WriteLine(secoundStudent.ToString());

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Is First Student != Secound Student");
            Console.WriteLine(firstStudent != secoundStudent);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Third Student = First Student.Clone() Deeply");
            Console.WriteLine("Is First Student == Third Student");
            Student thirdStudent = firstStudent.Clone();
            Console.WriteLine(firstStudent == thirdStudent);

            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Secound Student.CompareTo(Third Student)");
            Console.WriteLine(secoundStudent.CompareTo(thirdStudent));
        }
    }
}
