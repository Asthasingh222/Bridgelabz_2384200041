using System;

class Program
{
    // Method to calculate simple interest
    public static void CalculateInterest(double amount, double rate, int years)
    {
        // Check for invalid inputs (negative amount or rate)
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException(); // Throws an exception if values are negative
        }

        // Simple Interest formula: (P × R × T) / 100
        double interest = (amount * rate * years) / 100;

        Console.WriteLine("Interest: " + interest);
    }

    static void Main()
    {
        try
        {
            // Prompt user to enter amount
            Console.Write("Enter Amount: ");
            double am = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter interest rate
            Console.Write("Enter Rate: ");
            double rt = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter number of years
            Console.Write("Enter Time (in years): ");
            int yr = Convert.ToInt32(Console.ReadLine());

            // Call method to calculate interest
            CalculateInterest(am, rt, yr);
        }
        catch (ArgumentException)
        {
            // Handle case when amount or rate is negative
            Console.WriteLine("Invalid input: Amount and rate must be positive");
        }
        
    }
}
