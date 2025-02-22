using System;
using System.Text.RegularExpressions;

class BadWordFilter
{
    // Replaces bad words with ****
    public string CensorBadWords(string text, string[] badWords)
    {
        foreach (string word in badWords)
        {
            text = Regex.Replace(text, @"\b" + word + @"\b", "****", RegexOptions.IgnoreCase);
        }
        return text;
    }

    static void Main()
    {
        BadWordFilter filter = new BadWordFilter();
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" }; // List of words to censor

        string result = filter.CensorBadWords(input, badWords);
        Console.WriteLine(result); // Expected Output: "This is a **** bad example with some **** words."
    }
}
