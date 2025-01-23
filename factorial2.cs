using System;

class Program
{
    static void Main()
    {
        //enter a number to find it's factorial
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        //if a positive number
        if (number >= 0)
        {
            double factorial = 1;

            // Compute factorial using for loop
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            //display result
            Console.WriteLine("Factorial of {0} is {1}",number,factorial);
        }
        else
        {.
            Console.WriteLine("Not a positive integer.");
        }
    }
}
