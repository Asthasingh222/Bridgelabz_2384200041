using System;

class Program
{
    static void Main()
    {
        //taking int input to find it;s factorial
        Console.Write("Enter a integer: ");
        int number = int.Parse(Console.ReadLine());

        //if a positive number
        if (number >= 0)
        {
            double factorial = 1;
            int i = 1;

            // Compute factorial using while loop
            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine("Factorial of {0} is {1}",number,factorial);
        }
        else
        {
            Console.WriteLine("Not a positive integer.");
        }
    }
}
