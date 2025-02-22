using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CurrencyExtractor
{
    public List<string> ExtractCurrencies(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\$\s?\d+\.\d{2}");
        List<string> values = new List<string>();

        foreach (Match match in matches)
        {
            values.Add(match.Value);
        }

        return values;
    }

    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        CurrencyExtractor extractor = new CurrencyExtractor();
        List<string> values = extractor.ExtractCurrencies(text);
        Console.WriteLine("Extracted Currency Values: " + string.Join(", ", values));
    }
}
