using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CalcLib.IntelliTests
{
    public partial class CalcTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CalcTest))]
[PexRaisedException(typeof(DivideByZeroException))]
public void DivTestThrowsDivideByZeroException652()
{
    int i;
    i = this.DivTest(0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(CalcTest))]
[PexRaisedException(typeof(AssertFailedException))]
public void DivTestThrowsAssertFailedException564()
{
    int i;
    i = this.DivTest(0, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(CalcTest))]
[PexRaisedException(typeof(OverflowException))]
public void DivTestThrowsOverflowException246()
{
    int i;
    i = this.DivTest(int.MinValue, -1);
}
    }
}
