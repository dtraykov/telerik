using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolProject;

namespace SchoolUnitTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestStudentConstructor1()
        {
            Student student = new Student("Goshu", "Goshuv", 8);

            Assert.AreEqual("Goshu", student.FirstName);
        }

        [TestMethod]
        public void TestStudentConstructor2()
        {
            Student student = new Student("Akaciq", "Trendafilova", 7);

            Assert.AreEqual("Trendafilova", student.LastName);
        }

        [TestMethod]
        public void TestStudentConstructor3()
        {
            Student student = new Student("Zelka", "Morkovkova", 6);

            Assert.AreEqual(6, student.ClassNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentConstructor4_ThrowsException()
        {
            Student student = new Student(string.Empty, "Ivanov", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentConstructor5_ThrowsException()
        {
            Student student = new Student("Goshu", null, 10);
        }

        [TestMethod]
        public void TestCourseConstructor1()
        {
            Disciplines course = new Disciplines("C# Fundamentals Part I", 8, 8);

            Assert.AreEqual("C# Fundamentals Part I", course.Name);
        }

        [TestMethod]
        public void TestCourseConstructor2()
        {
            Disciplines course = new Disciplines("C# Fundamentals Part I", 8, 8);

            Assert.AreEqual(8, course.Lectures);
        }

        [TestMethod]
        public void TestCourseConstructor3()
        {
            Disciplines course = new Disciplines("C# Fundamentals Part I", 8, 12);

            Assert.AreEqual(12, course.Exercises);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseConstructor4_ThrowsException()
        {
            Disciplines discipline = new Disciplines(null, 8, 12);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseConstructor5_ThrowsException()
        {
            Disciplines discipline = new Disciplines("a", -1, 12);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseConstructor6_ThrowsException()
        {
            Disciplines discipline = new Disciplines("C#", 20, -6);
        }

        [TestMethod]
        public void TestTeacherConstructor1()
        {
            List<Disciplines> courses = new List<Disciplines>();
            courses.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            courses.Add(new Disciplines("C# Fundamentals Part II", 15, 5));
            courses.Add(new Disciplines("Object-Oriented Programming", 9, 19));
            courses.Add(new Disciplines("ASP.NET MVC", 8, 8));

            Teacher teacher = new Teacher("Nikolay", "Kostov", courses);

            Assert.AreEqual("ASP.NET MVC", teacher.Discipline[3].Name);
        }

        [TestMethod]
        public void TestTeacherConstructor2()
        {
            List<Disciplines> courses = new List<Disciplines>();
            courses.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            courses.Add(new Disciplines("C# Fundamentals Part II", 15, 5));
            courses.Add(new Disciplines("Object-Oriented Programming", 9, 19));
            courses.Add(new Disciplines("ASP.NET MVC", 8, 8));

            Teacher teacher = new Teacher("Nikolay", "Kostov", courses);

            Assert.AreEqual(9, teacher.Discipline[2].Lectures);
        }

        [TestMethod]
        public void TestTeacherConstructor3()
        {
            List<Disciplines> courses = new List<Disciplines>();

            courses.Add(new Disciplines("C# Fundamentals Part I", 10, 0));
            courses.Add(new Disciplines("C# Fundamentals Part II", 15, 5));
            courses.Add(new Disciplines("Object-Oriented Programming", 9, 19));
            courses.Add(new Disciplines("ASP.NET MVC", 8, 8));

            Teacher teacher = new Teacher("Nikolay", "Kostov", courses);

            Assert.AreEqual(5, teacher.Discipline[1].Exercises);
        }

        [TestMethod]
        public void TestSchoolClassConstructor1()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Kiril", "Nikolov", 1));
            students.Add(new Student("Stamo", "Petkov", 2));

            List<Disciplines> courses = new List<Disciplines>();

            courses.Add(new Disciplines("C# Fundamentals Part I", 10, 10));
            courses.Add(new Disciplines("C# Fundamentals Part II", 18, 3));
            courses.Add(new Disciplines("Object-Oriented Programming", 8, 1));
            courses.Add(new Disciplines("Knowledge Sharing and Teamwork", 10, 0));

            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher("Svetlin", "Nakov", courses));

            SchoolClass schoolClass = new SchoolClass("XIIc", students, teachers);

            Assert.AreEqual("Nakov", schoolClass.Teacher[0].LastName);
        }
    }
}
