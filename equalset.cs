using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> hs1 = new HashSet<int>(new int[] { 1, 2, 3 });
        HashSet<int> hs2 = new HashSet<int>(new int[] { 3, 2, 1 });

        string s = "true";

        if (!hs1.SetEquals(hs2)) // Directly compare HashSets
        {
            s = "false";
        }

        Console.WriteLine(s);
    }
}
