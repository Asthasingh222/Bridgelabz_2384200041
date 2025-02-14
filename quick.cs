using System;

class Quick
{
    // Function to swap two elements in the array
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // Function to partition the array and place the pivot at the correct position
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Choosing the last element as the pivot
        int i = low - 1; // Index of the smaller element

        for (int j = low; j < high; j++)
        {
            // If current element is smaller than pivot, swap it with the greater element pointed by i
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        // Swap the pivot element with the element at i+1 to place it at its correct position
        Swap(arr, i + 1, high);
        return i + 1; // Return pivot index
    }

    // Function to perform QuickSort recursively
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Find partition index
            int pi = Partition(arr, low, high);

            // Recursively sort elements before and after partition
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    // Function to display the sorted array
    static void Display(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + "  ");
        Console.WriteLine();
    }

    // Main function to test QuickSort
    public static void Main(string[] args)
    {
        int[] productprice = { 45, 23, 98, 67, 44, 90 };

        Console.WriteLine("Original array:");
        Display(productprice);

        QuickSort(productprice, 0, productprice.Length - 1);

        Console.WriteLine("Sorted array:");
        Display(productprice);
    }
}