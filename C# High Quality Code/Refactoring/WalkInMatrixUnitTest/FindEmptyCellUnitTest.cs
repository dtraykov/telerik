using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalkInMatrix;

namespace WalkInMatrixUnitTest
{
    [TestClass]
    public class FindEmptyCellUnitTest
    {
        [TestMethod]
        public void TestFindEmptyCellEmptyMatrix()
        {
            int[,] matrix = new int[5, 5];
            Cell cell = WalkInMatrix.FindEmptyCell(matrix);
            Assert.AreEqual(0, cell.Row);
            Assert.AreEqual(0, cell.Col);
        }

        [TestMethod]
        public void TestFindEmptyCellFullMatrix()
        {
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 1;
            matrix[1, 0] = 1;
            matrix[1, 1] = 1;
            Cell cell = WalkInMatrix.FindEmptyCell(matrix);
            Assert.AreEqual(null, cell);
        }

        [TestMethod]
        public void TestFindEmptyCell()
        {
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 1;
            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            Cell cell = WalkInMatrix.FindEmptyCell(matrix);
            Assert.AreEqual(1, cell.Row);
            Assert.AreEqual(0, cell.Col);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestFindEmptyCellNullMatrix()
        {
            int[,] matrix = null;
            WalkInMatrix.FindEmptyCell(matrix);
        }
    }
}
