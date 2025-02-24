using System;
using System.Collections.Generic;
using System.Reflection;

// Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class ExpensiveOperations
{
    private static Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Compute(int x)
    {
        if (cache.ContainsKey(x))
            return cache[x];

        int result = x * x; // Expensive computation
        cache[x] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        ExpensiveOperations obj = new ExpensiveOperations();
        Console.WriteLine(obj.Compute(5)); // Computed
        Console.WriteLine(obj.Compute(5)); // Cached
    }
}
