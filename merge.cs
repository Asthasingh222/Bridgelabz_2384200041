using System;

class MergeAlgo
{
    // Merges two sorted subarrays into one sorted array
    static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1; // Size of left subarray
        int n2 = r - m;     // Size of right subarray

        // Temporary arrays to store left and right subarrays
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copy data to temp arrays L[] and R[]
        for (int i = 0; i < n1; i++)
            L[i] = arr[l + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[m + 1 + j];

        int i = 0, j = 0, k = l; // Initial indexes of subarrays and merged array

        // Merge the two subarrays back into arr[l..r]
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
                arr[k++] = L[i++];
            else
                arr[k++] = R[j++];
        }

        // Copy any remaining elements from L[] if any
        while (i < n1)
            arr[k++] = L[i++];

        // Copy any remaining elements from R[] if any
        while (j < n2)
            arr[k++] = R[j++];
    }

    // Recursive MergeSort function to divide the array
    static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2; // Find the middle point

            // Recursively sort first and second halves
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            // Merge the sorted halves
            Merge(arr, l, m, r);
        }
    }

    // Function to display the sorted array
    static void Display(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + "  ");
        Console.WriteLine();
    }

    // Main function to test MergeSort
    public static void Main(string[] args)
    {
        int[] bookprice = { 45, 23, 98, 67, 44, 90 };
        Console.WriteLine("Original array:");
        Display(bookprice);

        MergeSort(bookprice, 0, bookprice.Length - 1);

        Console.WriteLine("Sorted array:");
        Display(bookprice);
    }
}
