using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        int maxFactor = 10; // Initial array size
        int[] factors = new int[maxFactor];
        int index = 0; // To keep track of current array position

        // Loop to find factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if 'i' is a factor
            {
                if (index == maxFactor) // Resize the array if needed
                {
                    //double the size of the array and create a new array temp
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    
                    //copy the data from factors array to temp array
                    Array.Copy(factors, temp, factors.Length);

                    //replace old array with temp
                    factors = temp;
                }
                factors[index++] = i; // Store the factor
            }
        }

         // Display factors
        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}