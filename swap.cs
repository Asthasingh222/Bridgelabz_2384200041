using System;

class Program6
{
    /// swap two numbers
    static void Main()
    {
        Console.Write("Enter first Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
    
        // Calculation to swap two numbers
        int temp = num1;
        num1 =num2;
        num2 =temp;
        Console.WriteLine("The swapped numbers are {0} and {1}",num1,num2);
    }
}
