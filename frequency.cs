using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Create a dictionary to store the frequency of each word
        Dictionary<string, int> d = new Dictionary<string, int>();

        // Initialize an array of strings
        string[] s = { "apple", "banana", "apple", "orange" };

        // Iterate over the array and count occurrences of each word
        for (int i = 0; i < s.Length; i++)
        {
            if (d.ContainsKey(s[i]))
                d[s[i]]++;
            else    d[s[i]] = 1;
        }

        // Display the frequency of each word
        foreach (var item in d)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
}
