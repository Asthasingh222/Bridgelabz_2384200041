using System;

class Program
{
    static void CauseIndexOutOfRangeException()
    {
        string str = "Hello";
        try
        {
            Console.WriteLine(str[10]); // Invalid index access
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
