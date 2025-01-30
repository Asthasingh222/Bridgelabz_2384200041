using System;

class Program
{
    static void CauseFormatException()
    {
        try
        {
            int number = int.Parse("ABC123"); // Non-numeric input
        }
        catch (FormatException e)
        {
            Console.WriteLine("Caught FormatException: " + e.Message);
        }
    }

    static void Main()
    {
        CauseFormatException();
    }
}
