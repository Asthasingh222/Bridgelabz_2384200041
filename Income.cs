using System;

class Program
{
    /// Calculates the total income by adding salary and bonus.
    static void Main()
    {
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculating total income
        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR {0} and bonus is INR {1}. Hence Total Income is INR {2}",salary,bonus,totalIncome);
    }
}
