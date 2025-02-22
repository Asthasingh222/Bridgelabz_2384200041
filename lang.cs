using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class LanguageExtractor
{
    public List<string> ExtractLanguages(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b(Java|Python|JavaScript|Go|Dart)\b", RegexOptions.IgnoreCase);
        List<string> languages = new List<string>();

        foreach (Match match in matches)
        {
            languages.Add(match.Value);
        }

        return languages;
    }

    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        LanguageExtractor extractor = new LanguageExtractor();
        List<string> languages = extractor.ExtractLanguages(text);
        Console.WriteLine("Extracted Languages: " + string.Join(", ", languages));
    }
}
