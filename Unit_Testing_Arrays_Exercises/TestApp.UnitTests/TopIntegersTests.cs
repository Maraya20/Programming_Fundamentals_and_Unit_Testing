using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;
 
public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        int[] numbers = Array.Empty<int>();

        TopIntegers topIntegers = new TopIntegers(); // Create an object
        string result = topIntegers.FindTopIntegers(numbers);

        Assert.AreEqual("", result); // Expecting an empty string
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        int[] numbers = { 5, 4, 3, 2, 1 };

        TopIntegers topIntegers = new TopIntegers(); // Create an object
        string result = topIntegers.FindTopIntegers(numbers);

        Assert.AreEqual("5 4 3 2 1", result); 
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        int[] numbers = { 5 };

        TopIntegers topIntegers = new TopIntegers(); // Create an object
        string result = topIntegers.FindTopIntegers(numbers);

        Assert.AreEqual("5", result);
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        int[] numbers = { 5, 3, 4, 7, 2, 1 };

        TopIntegers topIntegers = new TopIntegers(); // Create an object
        string result = topIntegers.FindTopIntegers(numbers);

        Assert.AreEqual("7 2 1", result);
    }
}

