using System;

class Program1
{
    // Finds the quotient and remainder of two numbers using division and modulus operators.
    static void Main()
    {
        // Taking user input
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculating quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Displaying the result
        Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}",quotient,remainder,number1,number2);
    }
}
