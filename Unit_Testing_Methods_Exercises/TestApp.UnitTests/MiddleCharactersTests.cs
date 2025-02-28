using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

//public static string GetMiddleChars(string input)
//{
//    int length = input.Length;

//    if (string.IsNullOrWhiteSpace(input))
//    {
//        return "Empty string";
//    }

//    if (length % 2 == 0)
//    {
//        return input.Substring((length / 2) - 1, 2); // Maraya -> ra, (substring(start_index, string_length))
//    }
//    else
//    {
//        return input.Substring(length / 2, 1); // Maray -> r
//    }
public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {

        string input = "";
        string expected = "Empty string";

        string actual_result = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual_result);

    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {

        string input = "     ";
        string expected = "Empty string";

        string actual_result = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual_result);

    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {

        string input = "M";
        string expected = "M";

        string actual_result = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual_result);

    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {

        string input = "Maraya";
        string expected = "ra";

        string actual_result = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual_result);

    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {

        string input = "Pesho";
        string expected = "s";

        string actual_result = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual_result);

    }
}
