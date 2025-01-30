using System;

class Longest
{
    // Method to find longest word in the string
    public static string LongestWord(string input)
    {
        if (input.Trim().Length == 0) return ""; // Handle empty input

        int i = 0;
        int inputLength = input.Length;
        string currentWord = "";
        string[] words = new string[100]; // Assuming a maximum of 100 words
        int wordCount = 0;

        while (i < inputLength)
        {
            // If the character is not a space, add it to the current word
            if (input[i] != ' ')
            {
                currentWord += input[i];
            }
            else
            {
                // If we encounter a space and the current word is not empty, save it
                if (currentWord.Length > 0)
                {
                    words[wordCount++] = currentWord;
                    currentWord = ""; // Reset the current word
                }
            }
            i++;
        }

        // If the last word is not followed by a space, add it
        if (currentWord.Length > 0)
        {
            words[wordCount++] = currentWord;
        }

        // Find the longest word in the array
        string longest = "";
        for (int j = 0; j < wordCount; j++)
        {
            if (words[j].Length > longest.Length)
            {
                longest = words[j];
            }
        }

        return longest;
    }

    static void Main(string[] args)
    {
        // Prompt to take string as input
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Longest word in the string: {0}", LongestWord(text));
    }
}
