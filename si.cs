using System;

class Program
{
    static double CalculateSi(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
    static void Main(string[] args)
    {
        //take input for principal,rate and time
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter Rate: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());

        double si = CalculateSi(principal, rate, time);
        Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2}, and Time {3}.",si,principal,rate,time);
    }

}
