﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.QualityTools.Testing.Fakes;

namespace FakesDemo.Tests
{
    [TestClass()]
    public class GreetingTests
    {
        [TestMethod()]
        public void Hello_NotLeapYear()
        {
            // Arrange
            var userName = "Harada Takahiro";
            var expected = $"HELLO, {userName}! HAVE A NICE DAY~~!";
            var target = new Greeting();

            // Act
            string actual;
            using (ShimsContext.Create())
            {
                FakesDemo.Fakes.ShimCalendarUtilities.IsLeapYearInt32 = i => false;
                actual = target.Hello(userName);
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Hello_IsLeapYear()
        {
            // Arrange
            var userName = "Harada Takahiro";
            var expected = $"HEY, {userName}! THIS YEAR IS A LEAP YEAR! PLEASE CHECK YOUR CODES!";
            var target = new Greeting();

            // Act
            var actual = target.Hello(userName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
