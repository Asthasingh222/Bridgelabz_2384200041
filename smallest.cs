using System;

class Program
{
    static void Main()
    {
        // Prompt user for three number
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        // Check if first number is the smallest of all three
        Console.WriteLine("Is the first number the smallest? {0}",(a<b && a<c));
    }
}
