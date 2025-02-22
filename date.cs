using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class DateExtractor
{
    // Method to extract dates in dd/mm/yyyy format
    public List<string> ExtractDates(string text)
    {
        // Regular expression pattern to match dates in dd/mm/yyyy format
        MatchCollection matches = Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b");

        // List to store extracted dates
        List<string> dates = new List<string>();

        // Add matches to the list
        foreach (Match match in matches)
        {
            dates.Add(match.Value);
        }

        return dates;
    }

    static void Main()
    {
        string sampleText = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        DateExtractor extractor = new DateExtractor();
        List<string> dates = extractor.ExtractDates(sampleText);
        Console.WriteLine("Extracted Dates: " + string.Join(", ", dates));
    }
}
