using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0,originalNumber=number;

        // Loop until the original number is reduced to 0
        while (originalNumber != 0)
        {
            // Get the last digit using modulus
            int remainder = originalNumber % 10;

            // Add the digit to the sum
            sum += remainder;

            // Remove the last digit by integer division
            originalNumber /= 10;
        }

        // Check if the number is divisible by sum 
        if (number%sum==0)
            Console.WriteLine("{0} is Harshad Number.", number);
        else
            Console.WriteLine("{0} is not an Harshad number.", number);
    }
}
