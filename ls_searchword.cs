using System;

class Program
{
    static string FindSentenceWithWord(string[] sentences, string word)
    {
        foreach (var sentence in sentences)
        {
            if (sentence.Contains(word))
                return sentence; // Return the first matching sentence
        }
        return null; // Return null if no sentence contains the word
    }
    static void Main()
    {
        string[] sentences = { "Hello world", "C# is great", "Searching algorithms are useful" };
        string word = "C#";
        Console.WriteLine(FindSentenceWithWord(sentences, word)); // Output: "C# is great"
    }
}
