using System;

class Program
{
    static void Main()
    {
        double total = 0;
        double number;

        // Keep summing until user enters 0
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            number = double.Parse(Console.ReadLine());
            total += number;
        } while (number != 0);

        Console.WriteLine("The total sum is {0}",total);
    }
}
