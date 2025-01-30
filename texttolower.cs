using System;

class Program
{
    static string ToLowerCustom(string str)
    {
        char[] result = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
                result[i] = (char)(str[i] + 32); // ASCII conversion
            else
                result[i] = str[i];
        }
        return new string(result);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string customLower = ToLowerCustom(input);
        string builtInLower = input.ToLower();

        Console.WriteLine("Custom Lowercase: {0}",customLower);
        Console.WriteLine("Built-in ToLower: {0}",builtInLower);
    }
}
