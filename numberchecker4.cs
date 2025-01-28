using System;

class NumberChecker
{

    // Method to check if a number is a prime number
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Method to check if a number is a neon number
    static bool IsNeonNumber(int n)
    {
        int square = n * n;
        int sum = 0;
        while (square != 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == n;
    }

    // Method to check if a number is a spy number
    static bool IsSpyNumber(int n)
    {
        int sum = 0, product = 1;
        while (n != 0)
        {
            int digit = n % 10;
            sum += digit;
            product *= digit;
            n /= 10;
        }
        return sum == product;
    }

    // Method to check if a number is an automorphic number
    static bool IsAutomorphicNumber(int n)
    {
        int square = n * n;
        return square.ToString().EndsWith(n.ToString());
    }

    // Method to check if a number is a buzz number
    static bool IsBuzzNumber(int n)
    {
        return n % 7 == 0 || n % 10 == 7;
    }

    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Display results

        Console.WriteLine("The number is a prime number: {0}", IsPrime(number));
        Console.WriteLine("The number is a neon number: {0}", IsNeonNumber(number));
        Console.WriteLine("The number is a spy number: {0}", IsSpyNumber(number));
        Console.WriteLine("The number is an automorphic number: {0}", IsAutomorphicNumber(number));
        Console.WriteLine("The number is a buzz number: {0}", IsBuzzNumber(number));
    }
}