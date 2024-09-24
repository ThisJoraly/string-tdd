using System.Text.RegularExpressions;

namespace string_tdd;

[TestClass]
public class StringTddUnitTest
{
    public StringTddUnitTest()
    {
    }

    [TestMethod]
    public void ShortestWord_ReturnsCorrectWord()
    {
        string input = "This is a test string";
        string expected = "a";

        string result = new StringTdd().ShortestWord(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void WordCount_ReturnsCorrectCount()
    {
        string input = "A B C D E F";
        int expected = 6;

        int result = new StringTdd().WordCount(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CharCount_ReturnsCorrectCount()
    {
        string input = "ABCD EFGH IJKL";
        int expected = 14; // пробел - тоже символ!

        int result = new StringTdd().CharCount(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void NinthChar_ReturnsCorrectCharacter()
    {
        string input = "This is a test string";
        char expected = 'a';

        char result = new StringTdd().NinthChar(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void DigitCount_ReturnsCorrectCount()
    {
        string input = "A1B2C3";
        int expected = 3;

        int result = new StringTdd().DigitCount(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RepeatableDigits_ReturnsCorrectCount()
    {
        string input = "a 45161 b 1561913";
        int expected = 7;

        int result = new StringTdd().RepeatableDigits(input);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void PatternCount_ReturnsCorrectCount()
    {
        string input = "параметр, амнезия";
        int expected = 2;

        int result = new StringTdd().PatternCount(input, "ам");

        Assert.AreEqual(expected, result);
    }
}

