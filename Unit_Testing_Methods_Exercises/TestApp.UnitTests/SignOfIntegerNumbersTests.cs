using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        string value = "hello";
        string expected = "The input is not an integer!";

        string actual = SignOfIntegerNumbers.CheckSign(value);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        string value = "0";
        string expected = "The number 0 is zero.";

        string actual = SignOfIntegerNumbers.CheckSign(value);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        string value = "-1";
        string expected = "The number -1 is negative.";

        string actual = SignOfIntegerNumbers.CheckSign(value);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        string value = "1";
        string expected = "The number 1 is positive.";

        string actual = SignOfIntegerNumbers.CheckSign(value);

        Assert.AreEqual(expected, actual);
    }
}
