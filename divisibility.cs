using System;

class Program
{
    static void Main()
    {
        // Prompt user for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check divisibility by 5 and display result 
        Console.WriteLine("Is the number {0} divisible by 5? : {1} ",number,(number%5==0));
    }
}
