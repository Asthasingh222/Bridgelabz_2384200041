using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("Simple Interest:"+ simpleInterest);
    }
}
