using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.AreEqual(result, inputArray );
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = new string[] { "ab" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);


        // Assert
        Assert.That(result, Is.EqualTo(new[] { "ba" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] inputArray = new string[] { "abc", "123" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);


        // Assert
        Assert.That(result, Is.EqualTo(new[] { "cba", "321" }));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] inputArray = new string[] { "a@$%", "@@!" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);


        // Assert
        Assert.That(result, Is.EqualTo(new[] { "%$@a", "!@@" }));
    }
}
