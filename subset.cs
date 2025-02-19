using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> mainSet = new HashSet<int> { 1, 2, 3, 4 };

        Console.WriteLine("Is Subset: " + subset.IsSubsetOf(mainSet));
    }
}
