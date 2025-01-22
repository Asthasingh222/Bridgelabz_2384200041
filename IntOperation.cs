using System;

class Program2
{
    /// Performs integer operations and demonstrates operator precedence.
    static void Main()
    {
        Console.Write("Enter value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Performing integer operations
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        Console.WriteLine("The results of Int Operations are {0}, {1}, {2}, and {3}",result1,result2,result3,result4);
    }
}
