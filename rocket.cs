using System;

class Program
{
    static void Main()
    {
        // Prompt user for countdown start
        Console.Write("Enter countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using a while loop
        while (counter > 0)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine("Rocket Launch!");
    }
}
