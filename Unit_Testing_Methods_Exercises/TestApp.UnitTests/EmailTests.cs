using System.Net.Mail;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string Input = "test@example.com";
        bool expected = true;
        // Act
        bool actual = Email.IsValidEmail(Input);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        //Arrange
        string Input = "gggggg.com";
        bool expected = false;

        //Act

        bool actual = Email.IsValidEmail(Input);

        //Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        //Arrange
        string Input = "";
        bool expected = false;

        //Act

        bool actual = Email.IsValidEmail(Input);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}

  
