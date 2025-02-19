using System;
using System.Collections.Generic; // Required for SortedSet and IComparer

class DescendingComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x); // Compare in descending order
    }
}

class Program
{
    static void Main()
    {
        // Declare the SortedSet first
        SortedSet<int> sortedSet = new SortedSet<int>(new DescendingComparer());

        // Add elements one by one (instead of using {}) -> //O(log n) for all insertions
        sortedSet.Add(5);
        sortedSet.Add(1);
        sortedSet.Add(10);
        sortedSet.Add(3);
        sortedSet.Add(7);

        Console.WriteLine("Sorted in descending order:");
        foreach (int num in sortedSet) //O(n)
        {
            Console.WriteLine(num);
        }
    }
}
