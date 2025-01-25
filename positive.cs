using System;

class NumberAnalysis
{
    static void Main()
    {
        // Define an array to store 5 numbers
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            // Input each number
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check each number for positivity, negativity, or zero
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                string evenOdd = (number % 2 == 0) ? "even" : "odd";
                Console.WriteLine("{0} is positive and {1}.",number,evenOdd);
            }
            else if (number < 0)
                Console.WriteLine("{0} is negative.",number);
            else
                Console.WriteLine("Zero");
        }

        // Compare the first and last elements of the array
        if (numbers[0] > numbers[4])
            Console.WriteLine("First element is greater than the last element.");
        else if (numbers[0] < numbers[4])
            Console.WriteLine("First element is less than the last element.");
        else
            Console.WriteLine("First and last elements are equal.");
    }
}
