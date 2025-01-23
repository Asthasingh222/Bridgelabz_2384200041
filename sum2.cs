using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0, i = 1;

            // Sum using while loop
            while (i <= n)
            {
                sum += i;
                i++;
            }

            //sum using formula
            int formulaSum = n * (n + 1) / 2;

            Console.WriteLine("Sum using while loop: {0}",sum);
            Console.WriteLine("Sum using formula: {0}",formulaSum);
            Console.WriteLine("Results match? :"+ (sum == formulaSum));
        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
