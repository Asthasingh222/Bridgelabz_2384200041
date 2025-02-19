using System;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, long> memo = new Dictionary<int, long>();

    // Recursive Fibonacci (O(2^N))
    static long FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Recursive Fibonacci with Memoization (O(N))
    static long FibonacciMemoized(int n)
    {
        if (n <= 1)
            return n;
        
        if (memo.ContainsKey(n))
            return memo[n];
        
        memo[n] = FibonacciMemoized(n - 1) + FibonacciMemoized(n - 2);
        return memo[n];
    }

    // Iterative Fibonacci (O(N))
    static long FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;
        
        long a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    static void Main()
    {
        int[] fibNumbers = { 10, 30, 50 };

        foreach (var n in fibNumbers)
        {
            Console.WriteLine("Testing Fibonacci for N = " + n);

            // Normal Recursive
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Recursive result: " + FibonacciRecursive(n));
            stopwatch.Stop();
            Console.WriteLine("Recursive Fibonacci Time: " + stopwatch.ElapsedMilliseconds + "ms");

            // Memoized Recursive
            stopwatch.Restart();
            Console.WriteLine("Memoized Recursive result: " + FibonacciMemoized(n));
            stopwatch.Stop();
            Console.WriteLine("Memoized Recursive Fibonacci Time: " + stopwatch.ElapsedMilliseconds + "ms");

            // Iterative
            stopwatch.Restart();
            Console.WriteLine("Iterative result: " + FibonacciIterative(n));
            stopwatch.Stop();
            Console.WriteLine("Iterative Fibonacci Time: " + stopwatch.ElapsedMilliseconds + "ms");

            Console.WriteLine();
        }
    }
}