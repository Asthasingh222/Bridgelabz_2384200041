using System;

class Program
{
    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] > arr[mid + 1])
                right = mid; // Peak is in the left half
            else
                left = mid + 1; // Peak is in the right half
        }
        return left; // Return index of peak element
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 1 };
        Console.WriteLine(FindPeakElement(arr)); // Output: 2 (index of peak element 3)
    }
}
