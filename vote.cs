using System;

class Program
{
    static void Main()
    {
        // Prompt user for age
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        // Check if the person can vote
        if (age >= 18)
        {
            Console.WriteLine("The person's age is {0} and can vote.",age);
        }
        else
        {
            Console.WriteLine("The person's age is {0} and cannot vote.",age);
        }
    }
}
