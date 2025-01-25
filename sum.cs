using System;

class SumOfNumbers
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers (stop with 0 or negative):");

        while (true)
        {
            double input = double.Parse(Console.ReadLine());

            // Break if the number is zero or negative
            if (input <= 0) break;

            // Add the number to the array and update the index
            if (index < 10)
            {
                numbers[index++] = input;
            }
            else
            {
                Console.WriteLine("Array limit reached.");
                break;
            }
        }

        // Calculate the sum
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        Console.WriteLine("Total sum of the numbers: {0}",total);
    }
}
