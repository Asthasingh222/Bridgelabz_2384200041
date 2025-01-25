using System;

class Program
{
    static void Main()
    {
        // Step 1: Input the number
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        long number = long.Parse(input);

        // Step 2: Initialize an array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];

        // Step 3: Loop through each digit in the number and update the frequency array
        while (number > 0)
        {
            int digit = (int)(number % 10); // Extract the last digit
            frequency[digit]++;            // Increment the count for that digit
            number /= 10;                  // Remove the last digit
        }

        // Step 4: Display the frequency of each digit
        Console.WriteLine("Frequency of each digit:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit {0}: {1}",i,frequency[i]);
            }
        }
    }
}
