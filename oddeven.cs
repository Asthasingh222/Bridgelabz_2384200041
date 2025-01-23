using System;

class Program
{
    static void Main()
    {
        //enter a number to find odd and even numbers between 1 to n
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        //if a valid positive number
        if (number >= 0)
        {
            // check if odd or even
            for (int i = 1; i <= number; i++)
            {
                if(i%2==0)  Console.WriteLine("{0}: even ",i);
                else    Console.WriteLine("{0}: odd ",i);
            }

        }
        else
        {
            Console.WriteLine("Not a valid positive integer.");
        }
    }
}
