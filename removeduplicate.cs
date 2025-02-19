using System;
using System.Collections.Generic;

class Program
{
    // Function to remove duplicates while preserving order
    static void RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>(); // To track unique elements
        List<int> result = new List<int>(); // Stores unique elements in order

        foreach (int item in list)
        {
            if (!seen.Contains(item)) // If item is not seen before
            {
                seen.Add(item); // Mark item as seen
                result.Add(item); // Add to result
            }
        }

        list.Clear(); // Clear original list
        list.AddRange(result); // Copy unique elements back
    }

    // Function to display List
    static void Display(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };

        Console.WriteLine("Original List:");
        Display(list);

        RemoveDuplicates(list);

        Console.WriteLine("\nList after Removing Duplicates:");
        Display(list);
    }
}
