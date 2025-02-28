using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        //Arrange
        int[] numbers = new int[] { 1, 2, 3, 3, 5, 8, 8 };
        int[] expected = new int[] { 1, 8, 2, 5, 3 };

        // Act
        int[] result = Pattern.SortInPattern(numbers);
        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] numbers = Array.Empty<int>();


        int[] result = Pattern.SortInPattern(numbers);
        // Assert
        Assert.AreEqual(result, numbers);

    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] numbers = new int[] { 1 };
        int[] expected = new int[] { 1 };

        // Act
        int[] result = Pattern.SortInPattern(numbers);
        // Assert
        Assert.AreEqual(result, expected);
    }
}
