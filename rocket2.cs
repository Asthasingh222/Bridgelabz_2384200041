using System;

class Program
{
    static void Main()
    {
        // Prompt user for countdown start
        Console.Write("Enter countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using a for loop
        for (int i = counter; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Rocket Launch!");
    }
}
