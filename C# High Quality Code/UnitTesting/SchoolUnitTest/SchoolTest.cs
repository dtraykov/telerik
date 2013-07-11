using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolUnitTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructorTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course html = new Course("HTML");
            School school = new School(courses);
            school.AddCourse(html);
            Assert.AreEqual(html.Name, school.Courses[0].Name);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course html = new Course("HTML");
            school.AddCourse(html);
            school.RemoveCourse(html);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingCourseTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course html = new Course("HTML");
            school.RemoveCourse(html);
        }
    }
}
