using System.Text.RegularExpressions;

namespace string_tdd;

public class StringTdd
{
    public string ShortestWord(string input)
    {
        return input.Split(' ').OrderBy(s => s.Length).First();
    }

    public int WordCount(string input)
    {
        return input.Split(' ').Length;
    }

    public int CharCount(string input)
    {
        return input.Length;
    }

    public char NinthChar(string input)
    {
        return input[8];
    }

    public int DigitCount(string input)
    {
        return input.Count(char.IsDigit);
    }

    public int RepeatableDigits(string input)
    {
        return Regex.Matches(input, @"\d+").Select(m => m.Length).DefaultIfEmpty(0).Max();
    }   

    public int PatternCount(string input, string pattern)
    {
        return Regex.Matches(input, pattern).Count;
    }
}