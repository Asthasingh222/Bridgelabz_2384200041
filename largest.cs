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

        // Check largest of all three 
        Console.WriteLine("Is the first number the largest? {0}",(a>b && a>c));
        Console.WriteLine("Is the second number the largest? {0}",(b>a && b>c));
        Console.WriteLine("Is the third number the largest? {0}",(c>a && c>a));
    }
}
