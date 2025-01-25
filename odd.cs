using System;
using System.Linq;
class OddEvenArrays
{
    static void Main()
    {
        Console.WriteLine("Enter a natural number:");
        int number = int.Parse(Console.ReadLine());

        //exit if entered number is not a natural number
        if (number <= 0)
        {
            Console.WriteLine("Error: Not a natural number.");
            return;
        }

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }

        Console.WriteLine("Odd Numbers: " + string.Join(", ", odd.Take(oddIndex)));
        Console.WriteLine("Even Numbers: " + string.Join(", ", even.Take(evenIndex)));
    }
}
