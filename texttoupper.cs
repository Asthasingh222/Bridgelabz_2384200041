using System;

class Program
{
    static string ToUpperCustom(string str)
    {
        char[] result = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
                result[i] = (char)(str[i] - 32); // ASCII conversion
            else
                result[i] = str[i];
        }
        return new string(result);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string customUpper = ToUpperCustom(input);
        string builtInUpper = input.ToUpper();

        Console.WriteLine("Custom Uppercase: {0}",customUpper);
        Console.WriteLine("Built-in ToUpper: {0}",builtInUpper);
    }
}
