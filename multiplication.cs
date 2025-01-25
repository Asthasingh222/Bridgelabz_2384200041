using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.WriteLine("Enter a number for its multiplication table:");
        int number = int.Parse(Console.ReadLine());

        // Define an array to store the results
        int[] table = new int[10];

        // Calculate the multiplication table
        for (int i = 0; i < 10; i++)
        {
            table[i] = number * (i + 1);
        }

        // Display the multiplication table
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}",number,i+1,table[i]);
        }
    }
}
