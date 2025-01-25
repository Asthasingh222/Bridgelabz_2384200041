using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer for FizzBuzz: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Create a string array to store FizzBuzz results
        string[] results = new string[number + 1];

        // Loop from 0 to the entered number
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }

        // Display the results
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine("Position {0} = {1}",i,results[i]);
        }
    }
}
