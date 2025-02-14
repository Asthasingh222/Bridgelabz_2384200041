using System;

class Selection
{
    // Function to perform Selection Sort
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        // Move the boundary of the unsorted subarray one by one
        for (int i = 0; i < n - 1; i++)
        {
            // Assume the first element of the unsorted part as the minimum
            int min_indx = i;

            // Find the minimum element in the unsorted subarray
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_indx]) // Compare with the current minimum
                {
                    min_indx = j; // Update index of the new minimum
                }
            }

            // Swap the found minimum element with the first element of the unsorted subarray
            int temp = arr[i];
            arr[i] = arr[min_indx];
            arr[min_indx] = temp;
        }
    }

    // Function to display the elements of an array
    static void Display(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + "  ");
        }
        Console.WriteLine();
    }

    // Main function to test Selection Sort
    public static void Main(string[] args)
    {
        int[] scores = { 45, 23, 98, 67, 44, 90 };

        Console.WriteLine("Original array:");
        Display(scores);

        SelectionSort(scores);

        Console.WriteLine("Sorted array:");
        Display(scores);
    }
}
