using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class PascalTriangleTests
{
    [Test]
    public void Test_PrintTriangle_With_Smallest_Valid_Input_ShouldReturnCorrectString()
    {
        // Arrange
        int n = 1;
        string expected = "1 \n";

        // Act
        string actual = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_PrintTriangle_With_Positive_Number_ShouldReturnCorrectString()
    {
        // Arrange
        int n = 3;
        string expected = "1 \n1 1 \n1 2 1 \n";

        // Act
        string actual = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_PrintTriangle_With_Large_Positive_Number_ShouldReturnCorrectString()
    {
        // Arrange
        int n = 10;
        string expected = "1 \n1 1 \n1 2 1 \n1 3 3 1 \n1 4 6 4 1 \n1 5 10 10 5 1 \n1 6 15 20 15 6 1 \n1 7 21 35 35 21 7 1 \n1 8 28 56 70 56 28 8 1 \n1 9 36 84 126 126 84 36 9 1 \n";


        // Act
        string actual = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_PrintTriangle_With_Endge_Case_Zero_ShouldReturnEmptyString()
    {
        // Arrange
        int n = 0;
        string expected = "";

        // Act
        string actual = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_PrintTriangle_With_Invalid_Negative_Number_ShouldReturnEmptyString()
    {
        // Arrange
        int n = -1;
        string expected = "";

        // Act
        string actual = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}