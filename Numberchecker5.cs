using System;
using System.Collections.Generic;
using System.Linq;

class NumberChecker
{
    // Method to find factors of a number
    public static int[] FindFactors(int number)
    {
        // First loop: Count the number of factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Create an array with the exact number of factors
        int[] factors = new int[count];

        // Second loop: Store the factors in the array
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }

// Method to find the greatest factor
public static int FindGreatestFactor(int[] factors)
{
    return factors.Max();
}

// Method to find the sum of factors
public static int SumOfFactors(int[] factors)
{
    return factors.Sum();
}

// Method to find the product of factors
public static double ProductOfFactors(int[] factors)
{
    double product = 1;
    foreach (int factor in factors)
    {
        product *= factor;
    }
    return product;
}

// Method to find the product of cubes of the factors
public static double ProductOfCubes(int[] factors)
{
    double product = 1.0;
    foreach (int factor in factors)
    {
        product *= Math.Pow(factor, 3);
    }
    return product;
}

// Check if the number is a perfect number
public static bool IsPerfectNumber(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }
    return sum == number;
}

// Check if the number is an abundant number
public static bool IsAbundantNumber(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }
    return sum > number;
}

// Check if the number is a deficient number
public static bool IsDeficientNumber(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }
    return sum < number;
}

// Check if the number is a strong number
public static bool IsStrongNumber(int number)
{
    int sum = 0;
    int temp = number;

    while (temp > 0)
    {
        int digit = temp % 10;
        sum += Factorial(digit);
        temp /= 10;
    }

    return sum == number;
}

// Helper method to calculate factorial
private static int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}


static void Main()
{
   // Prompt the user to enter a number
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    int[] factors = FindFactors(number);

    Console.WriteLine("Factors of {0}: {1}",number,string.Join(", ", factors));
    Console.WriteLine("Greatest Factor: {0}",FindGreatestFactor(factors));
    Console.WriteLine("Sum of Factors: {0}",SumOfFactors(factors));
    Console.WriteLine("Product of Factors: {0}",ProductOfFactors(factors));
    Console.WriteLine("Product of Cubes of Factors: {0}",ProductOfCubes(factors));
    Console.WriteLine("Is Perfect Number: {0}",IsPerfectNumber(number));
    Console.WriteLine("Is Abundant Number: {0}",IsAbundantNumber(number));
    Console.WriteLine("Is Deficient Number: {0}",IsDeficientNumber(number));
    Console.WriteLine("Is Strong Number: {0}",IsStrongNumber(number));
}
}
