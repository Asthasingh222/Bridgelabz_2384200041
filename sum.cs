using System;

class Program
{
    static void Main()
    {
        double total = 0;

        // Infinite loop
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double number = double.Parse(Console.ReadLine());

            if (number <= 0) break; // Break loop if number is 0 or negative
            total += number;
        }
        Console.WriteLine("The total sum is {0}",total);
    }
}
