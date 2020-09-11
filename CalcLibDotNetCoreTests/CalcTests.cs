using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibDotNetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcLibDotNetCore.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            int x1 = 1;
            int x2 = 2;
            int expected = 3;

            // Act
            int actual = Calc.Add(x1, x2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubTest()
        {
            // Arrange
            int x1 = 5;
            int x2 = 2;
            int expected = 3;

            // Act
            int actual = Calc.Sub(x1, x2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MulTest()
        {
            // Arrange
            int x1 = 2;
            int x2 = 3;
            int expected = 6;

            // Act
            int actual = Calc.Mul(x1, x2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivTest()
        {
            // Arrange
            int x1 = 6;
            int x2 = 2;
            int expected = 3;

            // Act
            int actual = Calc.Div(x1, x2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
