using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolUnitTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentConstructorTest()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.Name, "Pesho Peshov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void UniqueNumberTestStartValue()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumberTestEndValue()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestStartValueMinusOne()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 9999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlusOne()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 100000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlus10000()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 199999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void ToStringTest()
        {
            string name = "Pesho Peshov";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            string expected = "Student Pesho Peshov, ID 12345; ";
            string actual;
            actual = student.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
