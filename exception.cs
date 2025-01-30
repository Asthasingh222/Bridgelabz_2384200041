using System;

class Program
{
    static void CauseIndexOutOfRangeException()
    {
        int[] arr = { 1, 2, 3 };
        try
        {
            Console.WriteLine(arr[5]); // Invalid index access
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Caught IndexOutOfRangeException: " + e.Message);
        }
    }

    static void Main()
    {
        CauseIndexOutOfRangeException();
    }
}
