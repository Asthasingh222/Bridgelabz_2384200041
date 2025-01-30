using System;

class Duplicate
{
    // Method to remove duplicates from a string
    public static string RemoveDuplicates(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            bool isDuplicate = false;

            // Check if the character is already in the result string
            for (int j = 0; j < result.Length; j++)
            {
                if (text[i] == result[j])
                {
                    isDuplicate = true;
                    break;  // Stop checking if we find a match
                }
            }

            // If not a duplicate, add to result
            if (!isDuplicate)
            {
                result += text[i];
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        // Prompt to take string as input
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.WriteLine("String after removing duplicate characters: {0}", RemoveDuplicates(text));
    }
}
