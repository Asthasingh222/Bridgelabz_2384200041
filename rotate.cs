using System;
using System.Collections;

class Program
{
    // Function to rotate ArrayList
    static void RotateArray(ArrayList arr, int d)
    {
        int n = arr.Count;
        d %= n; // Handle cases where d > n

        if (d == 0) return; // No need to rotate if d is 0

        // Create a separate copy of first `d` elements
        ArrayList temp = new ArrayList(arr.GetRange(0, d)); // Copy elements

        // Remove first `d` elements
        arr.RemoveRange(0, d);

        // Add removed elements at the end
        arr.AddRange(temp);
    }

    // Function to display ArrayList
    public static void Display(ArrayList arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + "  ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        ArrayList arr = new ArrayList { 10, 20, 30, 40, 50 };
        int d = 2; // Rotate by 2 positions

        Console.WriteLine("Original list:");
        Display(arr);

        RotateArray(arr, d);

        Console.WriteLine("\nRotated list:");
        Display(arr);
    }
}
