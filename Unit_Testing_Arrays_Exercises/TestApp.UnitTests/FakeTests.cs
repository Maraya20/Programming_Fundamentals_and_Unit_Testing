using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] chars = { '0', 'q', 'a' };
        char[] expected = { 'q', 'a' };

        char[] result = Fake.RemoveStringNumbers(chars);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] chars = { 'a', 'q', 'a' };
        char[] expected = { 'a', 'q', 'a' };

        char[] result = Fake.RemoveStringNumbers(chars);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] chars = Array.Empty<char>();

        char[] result = Fake.RemoveStringNumbers(chars);

        Assert.AreEqual(chars, result);
    }
}
