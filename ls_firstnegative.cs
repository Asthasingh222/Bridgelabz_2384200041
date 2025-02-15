using System;

class Program
{
    static int FirstNegative(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
                return i; // Return the index of the first negative number
        }
        return -1; // Return -1 if no negative number is found
    }

    static void Main()
    {
        int[] arr = { 3, 7, 2, -5, 9, -1 };
        Console.WriteLine(FirstNegative(arr)); // Output: 3
    }
}
