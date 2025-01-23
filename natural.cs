using System;

class Program
{
    static void Main()
    {
        // Prompt user for a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Check if it's a natural number (positive integer)
        if (n > 0)
        {
            int sum = n * (n + 1) / 2; // Formula for sum of n natural numbers
            Console.WriteLine("The sum of {0} natural numbers is {1}",n,sum);
        }
        else
        {
            Console.WriteLine("The number {0} is not a natural number",n);
        }
    }
}
