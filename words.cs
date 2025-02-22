using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RepeatingWordsFinder
{
    public List<string> FindRepeatingWords(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b(\w+)\b\s+\b\1\b", RegexOptions.IgnoreCase);
        List<string> words = new List<string>();

        foreach (Match match in matches)
        {
            words.Add(match.Groups[1].Value);
        }

        return words;
    }

    static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        RepeatingWordsFinder finder = new RepeatingWordsFinder();
        List<string> words = finder.FindRepeatingWords(text);
        Console.WriteLine("Repeating Words: " + string.Join(", ", words));
    }
}
