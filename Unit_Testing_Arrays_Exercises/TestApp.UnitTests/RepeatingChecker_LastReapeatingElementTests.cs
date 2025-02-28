using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] numbers = Array.Empty<int>();
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {

        int[] numbers = new int[] { 1 };
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        int[] numbers = new int[] { 1, 2, 3 };
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        int[] numbers = new int[] { -1, -1 };
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {

        int[] numbers = new int[] { -3, -4, -3,-4 };
        int expected = -4;

        int actual = RepeatingChecker.FindLastRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        int[] numbers = new int[] { 1, 2, -3, -4, -3, -4 };
        int expected = -4;

        int actual = RepeatingChecker.FindLastRepeatingElement(numbers);

        Assert.AreEqual(expected, actual);
    }
}
