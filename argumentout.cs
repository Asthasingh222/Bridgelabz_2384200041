using System;

class Program
{
    static void CauseArgumentOutOfRangeException()
    {
        string str = "Hello";
        try
        {
            Console.WriteLine(str.Substring(3, 10)); // Start index + length exceeds string length
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Caught ArgumentOutOfRangeException: " + e.Message);
        }
    }

    static void Main()
    {
        CauseArgumentOutOfRangeException();
    }
}
