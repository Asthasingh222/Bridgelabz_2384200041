using System;

class GCD_LCM_Calculator
{
    // Function to calculate GCD using the Euclidean algorithm
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate LCM using the formula: LCM(a, b) = (a * b) / GCD(a, b)
    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD of {0} and {1} is: {2}",num1,num2,GCD(num1,num2));
        Console.WriteLine("LCM of {0} and {1} is: {2}",num1,num2,LCM(num1,num2));
    }
}
