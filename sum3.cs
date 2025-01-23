using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        
        //if a natural number
        if (n > 0)
        {
            int sum = 0;

            // Sum using for loop
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            //sum using formula
            int formulaSum = n * (n + 1) / 2;

            //display output 
            Console.WriteLine("Sum using for loop: {0}",sum);
            Console.WriteLine("Sum using formula: {0}",formulaSum);
            Console.WriteLine("Results match? :"+(sum == formulaSum));
        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
