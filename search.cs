using System;
using System.Diagnostics;

class Program
{
    // Linear Search (O(N))
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // Element found
        }
        return -1; // Element not found
    }

    // Binary Search (O(log N)) - Assumes sorted array
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid; // Element found
            if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1; // Element not found
    }

    // Helper method to generate random data
    static int[] GenerateRandomData(int size)
    {
        Random rand = new Random();
        int[] data = new int[size];
        for (int i = 0; i < size; i++)
        {
            data[i] = rand.Next(1, size);
        }
        return data;
    }

    static void Main()
    {
        // Example dataset sizes
        int[] datasetSizes = { 1000, 10000, 1000000 };
        int target = 5000;
        int repetitions = 1000; // Number of repetitions to make the time measurable

        foreach (var size in datasetSizes)
        {
            Console.WriteLine("Testing with dataset size: " + size);

            // Generate random unsorted dataset
            int[] dataset = GenerateRandomData(size);

            // Measure time for Linear Search over multiple repetitions
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < repetitions; i++)
            {
                LinearSearch(dataset, target);
            }
            stopwatch.Stop();
            Console.WriteLine("Linear Search (for " + repetitions + " repetitions): " + stopwatch.ElapsedMilliseconds + "ms");

            // Measure time for Binary Search (first sort the data) over multiple repetitions
            Array.Sort(dataset);
            stopwatch.Restart();
            for (int i = 0; i < repetitions; i++)
            {
                BinarySearch(dataset, target);
            }
            stopwatch.Stop();
            Console.WriteLine("Binary Search (for " + repetitions + " repetitions): " + stopwatch.ElapsedMilliseconds + "ms");
            
            Console.WriteLine();
        }
    }
}
