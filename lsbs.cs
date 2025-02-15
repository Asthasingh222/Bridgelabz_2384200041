using System;

class Program
{
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                // Swap elements to their correct position
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
                return i + 1; // First missing positive
        }

        return n + 1; // If all numbers are in order, return the next positive integer
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1; // Target not found
    }

    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };
        int missingNumber = FindFirstMissingPositive((int[])arr.Clone());
        Array.Sort(arr);
        int target = 4;
        int targetIndex = BinarySearch(arr, target);

        Console.WriteLine("First missing positive: " + missingNumber); // Output: 2
        Console.WriteLine("Index of target: " + targetIndex); // Output: Index of 4 in sorted array
    }
}
