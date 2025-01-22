using System;

class Program
{
    /// Performs double operations and demonstrates operator precedence.
    static void Main()
    {
        // Taking user input
        Console.Write("Enter value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Performing double operations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        // Displaying the results
        Console.WriteLine("The results of Double Operations are {0}, {1}, {2}, and {3}",result1,result2,result3,result4);
    }
}
