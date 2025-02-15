using System;

class Program
{
    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] > arr[right])
                left = mid + 1; // Smallest element is in the right half
            else
                right = mid; // Smallest element is in the left half
        }
        return left; // Return the index of the smallest element
    }

    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
        Console.WriteLine(FindRotationPoint(arr)); // Output: 4
    }
}
