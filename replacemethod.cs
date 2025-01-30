using System;

class Replace
{
    // Method to find longest word in the string
    public static string ReplaceWord(string input,string word,string rep)
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

        // Find the a word and replace it with another word
        string result="";
        for (int j = 0; j < wordCount; j++)
        {
            if(words[j]==word)   result+=rep +" ";
            else    result+=words[j]+" ";
        }

        return result;
    }

    static void Main(string[] args)
    {
        // Prompt to take string as input
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.Write("Enter a word to remove it from text: ");
        string word = Console.ReadLine();

        Console.Write("Enter a word to add in place of removed word in the text: ");
        string rep = Console.ReadLine();

        Console.WriteLine("string after removing {0} : {1}",word,ReplaceWord(text,word,rep) );
    }
}
