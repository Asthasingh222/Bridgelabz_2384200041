using System;

class Program
{
     // Recursively calculates the sum of n natural numbers.
    static int SumRecursive(int n)
    {
        if (n == 1) return 1; // Base case: sum of first 1 number is 1
        return n + SumRecursive(n - 1); // Recursive case
    }
    static int SumByFormula(int n)
    {
         // Calculate sum using the formula
            int s = n * (n + 1) / 2;
            return s;
    }
    static void Main(string[] args)
    {
        // Prompt user to enter a natural number
        Console.Write("Enter a natural number: ");
        
        // Parse the input and ensure it is greater than 0
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            // Calculate sum using recursion
            int sumRecursive = SumRecursive(n);
            // Calculate sum using the formula
            int sumFormula = SumByFormula(n);

            // Display results
            Console.WriteLine("Sum using recursion: {0}",sumRecursive);
            Console.WriteLine("Sum using formula: {0}",sumFormula);
            // Check if both results match
            Console.WriteLine("Results are {0}",sumRecursive == sumFormula ? "correct" : "incorrect");
        }
        else
        {
            Console.WriteLine("Input is not a valid natural number.");
        }
    }

   
}
