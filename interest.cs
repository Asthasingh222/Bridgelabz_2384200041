using System;

class Program
{
    static void Main()
    {
        //taking principal, rate and time as input
        Console.Write("Enter Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        //calculating simple interst using formula
        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}",simpleInterest,principal,rate,time);
    }
}
