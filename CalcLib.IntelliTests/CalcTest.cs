// <copyright file="CalcTest.cs">Copyright ©  2020</copyright>
using System;
using CalcLib;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLib.IntelliTests
{
    /// <summary>This class contains parameterized unit tests for Calc</summary>
    [PexClass(typeof(Calc))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalcTest
    {
        /// <summary>Test stub for Add(Int32, Int32)</summary>
        [PexMethod]
        public int AddTest(int x1, int x2)
        {
            int result = Calc.Add(x1, x2);
            Assert.AreEqual((x1+x2), result);
            return result;
        }

        /// <summary>Test stub for Div(Int32, Int32)</summary>
        [PexMethod]
        public int DivTest(int x1, int x2)
        {
            int result = Calc.Div(x1, x2);
            Assert.AreEqual((x1-x2), result);
            return result;
        }

        /// <summary>Test stub for Mul(Int32, Int32)</summary>
        [PexMethod]
        public int MulTest(int x1, int x2)
        {
            int result = Calc.Mul(x1, x2);
            Assert.AreEqual((x1*x2), result);
            return result;
        }

        /// <summary>Test stub for Sub(Int32, Int32)</summary>
        [PexMethod]
        public int SubTest(int x1, int x2)
        {
            int result = Calc.Sub(x1, x2);
            Assert.AreEqual((x1/x2), result);
            return result;
        }
    }
}
