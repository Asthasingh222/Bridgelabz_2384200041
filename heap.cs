using System;

class HeapSort
{
    // Function to heapify a subtree rooted at index i
    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;  // Initialize largest as root
        int left = 2 * i + 1;  // Left child
        int right = 2 * i + 2; // Right child

        // If left child is larger than root
        if (left < n && arr[left] > arr[largest])
            largest = left;

        // If right child is larger than the largest so far
        if (right < n && arr[right] > arr[largest])
            largest = right;

        // If largest is not root, swap and continue heapifying
        if (largest != i)
        {
            Swap(arr, i, largest);
            Heapify(arr, n, largest);
        }
    }

    // Function to perform Heap Sort
    static void HeapSortAlgo(int[] arr)
    {
        int n = arr.Length;

        // Build max heap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // Extract elements from heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i); // Move current root to end
            Heapify(arr, i, 0); // Call max heapify on reduced heap
        }
    }

    // Function to swap two elements in the array
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // Function to display the sorted array
    static void Display(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + "  ");
        Console.WriteLine();
    }

    // Main function to test Heap Sort
    public static void Main(string[] args)
    {
        int[] salaries = { 50000, 75000, 45000, 60000, 80000, 70000 };

        Console.WriteLine("Original Salary Demands:");
        Display(salaries);

        HeapSortAlgo(salaries);

        Console.WriteLine("Sorted Salary Demands:");
        Display(salaries);
    }
}
