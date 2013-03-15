using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.FindStudentsFirstNameBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int? age;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }

            set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException("Invalid name!");
                }

                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        throw new ArgumentException("Invalid name!");
                    }
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get 
            { 
                return this.lastName; 
            }

            set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException("Invalid name!");
                }

                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        throw new ArgumentException("Invalid name!");
                    }
                }

                this.firstName = value;
            }
        }

        public int? Age
        {
            get 
            { 
                return this.age; 
            }

            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.age = value;
            }
        }

        public static void FirstBeforeLast(Student[] students)
        {
            var firstBeforeLast =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;
            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public static void AgeRestriction(Student[] students)
        {
            var ageRestriction =
                from student in students
                where student.age > 18 && student.age < 24
                select student;
            foreach (var student in ageRestriction)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public static void SortByNameLambda(Student[] students)
        {
            var sortByNameLambda = students.OrderByDescending(f => f.FirstName).ThenByDescending(l => l.LastName);

            foreach (var student in sortByNameLambda)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public static void SortByNameLinq(Student[] students)
        {
            var sortByNameLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sortByNameLinq)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
