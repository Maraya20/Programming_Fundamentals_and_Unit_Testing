using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        int[] numbers = Array.Empty<int>();
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {

        int[] numbers = new int[] {0,0,0,0};
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        int[] numbers = new int[] { 1,2,3,4 };
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 6 };
        int expected = 1;

        int actual = Majority.IsEvenOrOddMajority(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        int expected = -1;

        int actual = Majority.IsEvenOrOddMajority(numbers);

        Assert.AreEqual(expected, actual);
    }
}