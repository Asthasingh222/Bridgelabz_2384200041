using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int> { 5, 3, 9, 1 };
        List<int> sortedList = new List<int>(numbers);
        sortedList.Sort();

        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }
}
