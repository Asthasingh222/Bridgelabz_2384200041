using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class LinkExtractor
{
    // Method to extract URLs from text
    public List<string> ExtractLinks(string text)
    {
        // Regular expression to match URLs (http and https)
        MatchCollection matches = Regex.Matches(text, @"https?:\/\/[^\s]+");

        List<string> links = new List<string>();

        foreach (Match match in matches)
        {
            links.Add(match.Value);
        }

        return links;
    }

    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        LinkExtractor extractor = new LinkExtractor();
        List<string> links = extractor.ExtractLinks(text);
        Console.WriteLine("Extracted Links: " + string.Join(", ", links));
    }
}
