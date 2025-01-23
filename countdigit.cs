using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize count to 0
        int count = 0;

        // Loop until the number is reduced to 0
        while (number != 0)
        {
            // Remove the last digit from the number
            number /= 10;
            // Increment the count for each digit
            count++;
        }

        // Display the total number of digits
        Console.WriteLine("The number of digits is: {0}", count);
    }
}
