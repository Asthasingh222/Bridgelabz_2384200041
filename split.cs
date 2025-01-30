using System;

class Program
{
    // Method to calculate string length without using string.Length
    static int GetStringLength(string str)
    {
        int length = 0;
        foreach (char c in str) // Iterate through each character
        {
            length++;
        }
        return length;
    }

    // Method to split text into words without using string.Split()
    static string[,] SplitWordsAndLengths(string str)
    {
        int wordCount = 0;
        int strLength = GetStringLength(str); // Get string length without using Length

        // Count words by checking spaces
        for (int i = 0; i < strLength; i++)
        {
            if ((i == 0 || str[i - 1] == ' ') && str[i] != ' ')
            {
                wordCount++;
            }
        }

        string[,] wordsArray = new string[wordCount, 2]; // 2D array to store words and their lengths
        int index = 0, wordStart = -1;

        for (int i = 0; i <= strLength; i++)
        {
            // Detect the start of a word
            if (i < strLength && str[i] != ' ' && wordStart == -1)
            {
                wordStart = i;
            }

            // Detect the end of a word
            if ((i == strLength || str[i] == ' ') && wordStart != -1)
            {
                string word = "";
                for (int j = wordStart; j < i; j++) // Extract word manually
                {
                    word += str[j];
                }

                wordsArray[index, 0] = word;
                wordsArray[index, 1] = GetStringLength(word).ToString(); // Store word length
                index++;
                wordStart = -1;
            }
        }

        return wordsArray;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string[,] wordsData = SplitWordsAndLengths(input);

        Console.WriteLine("\nWords and their lengths:");
        for (int i = 0; i < wordsData.GetLength(0); i++)
        {
            Console.WriteLine($"{wordsData[i, 0]} - {wordsData[i, 1]}");
        }
    }
}
