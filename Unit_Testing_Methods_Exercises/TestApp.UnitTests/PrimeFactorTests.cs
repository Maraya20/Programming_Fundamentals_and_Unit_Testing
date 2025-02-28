using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long number = 11;
        long expected = 11;

        long actual = PrimeFactor.FindLargestPrimeFactor(number);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long number = 20;
        long expected = 5;

        long actual = PrimeFactor.FindLargestPrimeFactor(number);

        Assert.AreEqual(expected, actual);
    }
}
