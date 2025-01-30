using System;

class Program
{
    public static int Occurrence(string input, string word)
    {
        int count = 0, i = 0;
        int inputLength = input.Length;
        int wordLength = word.Length;
        string currentWord = "";

        while (i < inputLength)
        {
            // If the character is not a space, add it to the current word
            if (input[i] != ' ')
            {
                currentWord += input[i];
            }
            else
            {
                // If a word was collected, compare it with the target word
                if (currentWord == word)
                {
                    count++;
                }
                currentWord = ""; // Reset for next word
            }
            i++;
        }

        // Check the last word in case there's no trailing space
        if (currentWord == word)
        {
            count++;
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.Write("Enter a word to find its occurrences in the text: ");
        string word = Console.ReadLine();

        Console.WriteLine("Occurrence of {0} in the string:{1}",word, Occurrence(text, word));
    }
}
