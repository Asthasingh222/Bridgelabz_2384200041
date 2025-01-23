using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize sum to 0 and store the original number
        int sum = 0, originalNumber = number;

        // Loop until the original number is reduced to 0
        while (originalNumber != 0)
        {
            // Get the last digit using modulus
            int remainder = originalNumber % 10;

            // Add the cube of the digit to the sum
            sum += remainder * remainder * remainder;

            // Remove the last digit by integer division
            originalNumber /= 10;
        }

        // Check if the sum equals the original number
        if (sum == number)
            Console.WriteLine("{0} is an Armstrong number.", number);
        else
            Console.WriteLine("{0} is not an Armstrong number.", number);
    }
}
