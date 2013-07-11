using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalkInMatrix;

namespace WalkInMatrixUnitTest
{
    [TestClass]
    public class CellUnitTest
    {
        [TestMethod]
        public void TestValidCell()
        {
            Cell cell = new Cell(3, 3);
            Assert.AreEqual(3, cell.Row);
            Assert.AreEqual(3, cell.Col);
        }

        [TestMethod]
        public void TestCellZero()
        {
            Cell cell = new Cell(0, 0);
            Assert.AreEqual(0, cell.Row);
            Assert.AreEqual(0, cell.Col);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCellNegativeRow()
        {
            Cell cell = new Cell(-3, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCellNegativeCol()
        {
            Cell cell = new Cell(3, -1);
        }
    }
}
