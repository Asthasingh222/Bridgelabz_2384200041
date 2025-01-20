using System;

class Program
{
    static void Main()
    {
		Console.WriteLine("Enter First Number:");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		int b = Convert.ToInt32(Console.ReadLine());
		int sum =a+b;
        Console.WriteLine("Sum : "+ sum);
    }
}
