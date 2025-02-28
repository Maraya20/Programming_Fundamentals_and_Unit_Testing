using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Arrange
        int n = 0;
        int expectedResult = 0;

        //Act
        int actualResult = Fibonacci.CalculateFibonacci(n);

        //Assert

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        //Arrange
        int n = 2;
        int expectedResult = 1;

        //Act
        int actualResult = Fibonacci.CalculateFibonacci(n);

        //Assert

        Assert.AreEqual(expectedResult, actualResult);
    }
}

    