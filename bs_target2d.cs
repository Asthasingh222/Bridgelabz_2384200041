using System;

class Program
{
    static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
                return true; // Target found
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false; // Target not found
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 3, 5 },
            { 7, 10, 11 },
            { 13, 15, 17 }
        };
        int target = 10;
        Console.WriteLine(SearchMatrix(matrix, target)); // Output: True
    }
}
