using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        List<string> input = new() {"mom", "bob"};
        bool expected = true;

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new();

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "hhthh"};

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new() { "hello", "ava", "boib" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsFalse(actual);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "AAbAa", "Cvc", "boB" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }
}
