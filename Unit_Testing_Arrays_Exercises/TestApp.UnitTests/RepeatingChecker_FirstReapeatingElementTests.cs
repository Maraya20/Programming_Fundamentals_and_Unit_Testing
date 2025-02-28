using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] numbers = Array.Empty<int>();
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        int[] numbers = new int[] { 1 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        int[] numbers = new int[] { 1,2,3 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        int[] numbers = new int[] { -5, -5 };
        int expected = -5;

        int actual = RepeatingChecker.FindFirstRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        int[] numbers = new int[] { 3, 2, 3, 2 };
        int expected = 3;

        int actual = RepeatingChecker.FindFirstRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        int[] numbers = new int[] { 3, 2, 3, 2, 5 };
        int expected = 3;

        int actual = RepeatingChecker.FindFirstRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }
}
