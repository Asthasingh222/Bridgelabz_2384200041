using System;

class Insertion
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            //key to insert it in sorted array
            int key = arr[i];
            int j = i - 1;

            //traverse until appropriate place is not found for key to insert(1st smaller element than key)
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];  //shifting to create position for key to insert
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void Display(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + "  ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] employeeIds = { 45, 23, 98, 67, 44, 90 };
        InsertionSort(employeeIds);
        Display(employeeIds);
    }
}
