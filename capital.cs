using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CapitalizedWordExtractor
{
    // Method to extract all capitalized words from the given text
    public List<string> ExtractCapitalizedWords(string text)
    {
        // Regular expression to match capitalized words (starting with an uppercase letter, followed by lowercase letters)
        MatchCollection matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");

        // List to store extracted capitalized words
        List<string> capitalizedWords = new List<string>();

        // Iterate through each match and add it to the list
        foreach (Match match in matches)
        {
            capitalizedWords.Add(match.Value);
        }

        // Return the list of extracted capitalized words
        return capitalizedWords;
    }

    static void Main()
    {
        // Create an instance of CapitalizedWordExtractor
        CapitalizedWordExtractor extractor = new CapitalizedWordExtractor();

        // Sample input text containing capitalized words
        string sampleText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        // Extract capitalized words from the sample text
        List<string> words = extractor.ExtractCapitalizedWords(sampleText);

        // Print the extracted capitalized words
        Console.WriteLine("Extracted Capitalized Words: " + string.Join(", ", words));
    }
}
