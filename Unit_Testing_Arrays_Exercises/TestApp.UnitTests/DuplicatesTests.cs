using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.AreEqual(result, numbers);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] {1, 2, 3};

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.AreEqual(result, numbers);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 1, 2 };
        int[] expected = new int[] { 1, 2, 3};

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 1, 1 };
        int[] expected = new int[] { 1 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.AreEqual(result, expected);
    }
}
