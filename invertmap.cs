using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Original Dictionary<K, V>
        Dictionary<string, int> originalMap = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        // Dictionary<V, List<K>> to store the inverted map
        Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

        // Iterate through the original dictionary
        foreach (var kvp in originalMap)
        {
            int value = kvp.Value;
            string key = kvp.Key;

            // If the value is not in the inverted map, add it
            if (!invertedMap.ContainsKey(value))
            {
                invertedMap[value] = new List<string>();
            }

            // Add the original key to the list
            invertedMap[value].Add(key);
        }

        // Print the inverted map
        Console.WriteLine("Inverted Dictionary:");
        foreach (var kvp in invertedMap)
        {
            Console.Write("{0} = [",kvp.Key);
            Console.Write(string.Join(", ", kvp.Value));
            Console.WriteLine("]");
        }
    }
}
