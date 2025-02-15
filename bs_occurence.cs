using System;

class Program
{
    static int BinarySearch(int[] arr, int target, bool findFirst)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                if (findFirst)
                    right = mid - 1; // Move left to find first occurrence
                else
                    left = mid + 1; // Move right to find last occurrence
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4, 5 };
        int target = 2;
        Console.WriteLine("First Occurrence: {0}",BinarySearch(arr, target, true));
        Console.WriteLine("Last Occurrence: {0}",BinarySearch(arr, target, false));
    }
}
