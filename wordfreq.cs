using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "file.txt"; // File containing text

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        // Read the entire file content
        string text = File.ReadAllText(filePath);

        // Convert text to lowercase and split into words
        char[] delimiters = { ' ', ',', '.', '!', '?', '\n', '\r', ';', ':' }; // Define delimiters for splitting
        string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Dictionary to store word counts
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        // Count word occurrences
        foreach (var word in words)
        {
            if (wordFrequency.ContainsKey(word))
                wordFrequency[word]++;
            else
                wordFrequency[word] = 1;
        }

        // Print the word frequency
        Console.WriteLine("Word Frequency:");
        foreach (var kvp in wordFrequency)
        {
            Console.WriteLine("{0}: {1}",kvp.Key,kvp.Value);
        }
    }
}
