using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Count digits and extract them
        int[] digits = new int[number.ToString().Length];
        int index = 0;

        while (number > 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        // Reverse and display
        Console.WriteLine("Reversed Number: " + string.Join("", digits));
    }
}
