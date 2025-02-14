using System;

class CountingSort
{
    // Function to perform Counting Sort
    static void CountingSortAlgo(int[] arr, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];

        // Count occurrences of each element
        for (int i = 0; i < arr.Length; i++)
            count[arr[i] - min]++;

        // Compute cumulative count
        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        // Place elements in sorted order
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        // Copy sorted elements back to original array
        for (int i = 0; i < arr.Length; i++)
            arr[i] = output[i];
    }

    // Function to display the sorted array
    static void Display(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + "  ");
        Console.WriteLine();
    }

    // Main function to test Counting Sort
    public static void Main(string[] args)
    {
        int[] studentAges = { 14, 17, 12, 16, 15, 11, 10, 13, 18, 12, 14, 16 };

        Console.WriteLine("Original Student Ages:");
        Display(studentAges);

        CountingSortAlgo(studentAges, 10, 18);

        Console.WriteLine("Sorted Student Ages:");
        Display(studentAges);
    }
}
