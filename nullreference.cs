using System;

class Program
{
    static void CauseNullReferenceException()
    {
        string str = null;
        try
        {
            Console.WriteLine(str.Length); // Accessing a method on a null string
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Caught NullReferenceException: " + e.Message);
        }
    }

    static void Main()
    {
        CauseNullReferenceException();
    }
}
