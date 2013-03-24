using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex4.Person
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void TestMethodName()
        {
            Person person = new Person("Goshu");
            Assert.AreEqual("Goshu", person.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethodNullName()
        {
            Person person = new Person("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethodNullName1()
        {
            Person person = new Person(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethodNullName2()
        {
            Person person = new Person(null, 33);
        }

        [TestMethod]
        public void TestMethodAge()
        {
            Person person = new Person("Goshu", 33);
            Assert.AreEqual(33, person.Age);
        }

        [TestMethod]
        public void TestMethodNullAge()
        {
            Person person = new Person("Goshu", null);
            Assert.AreEqual(string.Format("Name: {0}, Age: {1}", person.Name, "Age is not specified."), person.ToString());
        }

        [TestMethod]
        public void TestMethodNoneAge()
        {
            Person person = new Person("Goshu");
            Assert.AreEqual(string.Format("Name: {0}, Age: {1}", person.Name, "Age is not specified."), person.ToString());
        }
    }
}
