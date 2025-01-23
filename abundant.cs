using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        // Loop to find all divisors of the number
        for (int i = 1; i < number; i++)
        {
            // Check if i is a divisor
            if (number % i == 0)
            {
                sum += i;
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
            Console.WriteLine("{0} is an Abundant Number.", number);
        else
            Console.WriteLine("{0} is not an Abundant Number.", number);
    }
}
