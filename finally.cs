using System;
class FinallyEx
{
    static void Main(string[] args)
    {
        try
        {
            // Prompt user to enter two numbers
            Console.Write("Enter First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result =a/b;
            Console.WriteLine("Result: "+result);
        }
        //handle divideby zero exception
        catch (DivideByZeroException e)
        {
            Console.WriteLine("DivideByZeroException caught: " + e.Message);
        }
        //finally block
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
