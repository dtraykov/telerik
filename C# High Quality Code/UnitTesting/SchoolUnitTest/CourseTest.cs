using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolUnitTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorTest()
        {
            string name = "HTML";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "HTML");
        }

        [TestMethod]
        public void CourseConstructorTestListStudents()
        {
            string name = "HTML";
            Student pesho = new Student("Pesho Peshov", 12345);
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(pesho);
            Assert.IsTrue(course.Students.Contains(pesho));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void StudentListTestNull()
        {
            string name = "HTML";
            Course newCourse = new Course(name, null);
            Assert.IsTrue(newCourse.Students == null);
        }

        [TestMethod]
        public void AddStudentTestOneStudent()
        {
            string name = "HTML";
            Student pesho = new Student("Pesho Peshov", 12345);
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(pesho);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void AddStudentTestTwoStudents()
        {
            string name = "HTML";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12345);
            Student goshu = new Student("Goshu Goshuv", 54321);
            course.AddStudent(pesho);
            course.AddStudent(goshu);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTestSameStudentTwoTimes()
        {
            string name = "HTML";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12345);
            course.AddStudent(pesho);
            course.AddStudent(pesho);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestMoreThanMaximumStudents()
        {
            string name = "HTML";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            for (int i = 0; i < 29; i++)
            {
                Student pesho = new Student("Pesho Peshov", 10000 + i);
                course.AddStudent(pesho);
            }
        }

        [TestMethod]
        public void RemoveStudentTest()
        {
            string name = "HTML";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12345);
            Student goshu = new Student("Goshu Goshuv", 54321);
            course.AddStudent(pesho);
            course.AddStudent(goshu);
            course.RemoveStudent(pesho);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            string name = "HTML";
            List<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student pesho = new Student("Pesho Peshov", 12345);
            course.RemoveStudent(pesho);
        }

        [TestMethod]
        public void ToStringTestOneStudent()
        {
            string name = "HTML";
            Student pesho = new Student("Pesho Peshov", 12345);
            List<Student> students = new List<Student>();
            Course html = new Course(name, students);
            html.AddStudent(pesho);
            string expected = "Course name HTML; Student Pesho Peshov, ID 12345; ";
            string actual;
            actual = html.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTestTwoStudents()
        {
            string name = "HTML";
            Student pesho = new Student("Pesho Peshov", 12345);
            Student goshu = new Student("Goshu Goshuv", 54321);
            List<Student> students = new List<Student>();
            Course html = new Course(name, students);
            html.AddStudent(pesho);
            html.AddStudent(goshu);
            string expected = "Course name HTML; Student Pesho Peshov, ID 12345; Student Goshu Goshuv, ID 54321; ";
            string actual;
            actual = html.ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
