using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "input.txt";  // File containing words

        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split text into words using regular expressions
                    string[] words = Regex.Split(line.ToLower(), @"\W+");
                    
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }
            }

            // Get top 5 most frequent words
            var topWords = wordCount.OrderByDescending(x => x.Value).Take(5);

            Console.WriteLine("Top 5 most frequent words:");
            foreach (var word in topWords)
            {
                Console.WriteLine(word.Key + ": " + word.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
