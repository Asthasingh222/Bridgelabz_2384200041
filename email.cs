using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class EmailExtractor
{
    // Method to extract all email addresses from a given text
    public List<string> ExtractEmails(string text)
    {
        // Regular expression to match email patterns
        MatchCollection matches = Regex.Matches(text, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");

        // List to store extracted email addresses
        List<string> emailList = new List<string>();

        // Iterate through each match and add it to the list
        foreach (Match match in matches)
        {
            emailList.Add(match.Value);
        }

        // Return the list of extracted emails
        return emailList;
    }

    static void Main()
    {
        // Create an instance of the EmailExtractor class
        EmailExtractor extractor = new EmailExtractor();

        // Sample input text containing email addresses
        string sampleText = "Contact at test@example.com and help@support.org for more info.";

        // Extract email addresses from the sample text
        List<string> emails = extractor.ExtractEmails(sampleText);

        // Print the extracted email addresses
        Console.WriteLine("Extracted Emails: " + string.Join(", ", emails));
    }
}
