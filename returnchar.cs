using System;

class Program
{
    static char[] GetCharacters(string str)
    {
        char[] result = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            result[i] = str[i]; // Using index access instead of ToCharArray()
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] customChars = GetCharacters(input);
        char[] builtInChars = input.ToCharArray();

        Console.WriteLine("Custom Character Array: " + new string(customChars));
        Console.WriteLine("Built-in ToCharArray: " + new string(builtInChars));
    }
}
