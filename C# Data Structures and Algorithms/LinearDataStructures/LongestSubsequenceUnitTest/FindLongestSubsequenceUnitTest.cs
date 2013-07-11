using System;
using System.Collections.Generic;
using LongestSubsequenceOfEqualNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestSubsequenceUnitTest
{
    [TestClass]
    public class FindLongestSubsequenceUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyList()
        {
            LongestSubsequence.FindLongestSubsequence(new List<int>());
        }

        [TestMethod]
        public void TestOneElement()
        {
            List<int> numbers = new List<int>() { 4 };
            List<int> actual = LongestSubsequence.FindLongestSubsequence(numbers);
            List<int> expected = new List<int>() { 4 };

             CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNoLongestSubSequence()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> actual = LongestSubsequence.FindLongestSubsequence(numbers);
            List<int> expected = new List<int>() { 7 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNormalSubSequence()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 3, 3, 6, 7 };
            List<int> actual = LongestSubsequence.FindLongestSubsequence(numbers);
            List<int> expected = new List<int>() { 3, 3, 3 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFirstElementsSubSequence()
        {
            List<int> numbers = new List<int>() { 2, 2, 2, 3, 3, 6, 7 };
            List<int> actual = LongestSubsequence.FindLongestSubsequence(numbers);
            List<int> expected = new List<int>() { 2, 2, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEndElementsSubSequence()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 9, 9 };
            List<int> actual = LongestSubsequence.FindLongestSubsequence(numbers);
            List<int> expected = new List<int>() { 9, 9 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTwoEqualsSubSequence()
        {
            List<int> numbers = new List<int>() { 2, 2, 3, 4, 9, 9 };
            List<int> actual = LongestSubsequence.FindLongestSubsequence(numbers);
            List<int> expected = new List<int>() { 2, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
