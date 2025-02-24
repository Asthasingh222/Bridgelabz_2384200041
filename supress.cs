using System;
using System.Collections;  // Using non-generic ArrayList

class Program
{
    static void Main()
    {
        // ✅ Correctly suppress warnings
        #pragma warning disable CS0618  // Suppress obsolete warnings
        #pragma warning disable CS8600  // Suppress possible null reference assignment
        #pragma warning disable CS8602  // Suppress dereferencing a possibly null reference
        #pragma warning disable CS0168  // Suppress unused variable warnings
        #pragma warning disable CS0219  // Suppress assigned but unused variable warnings

        // ❌ Fix: Remove `?` since ArrayList is already nullable
        ArrayList list = null;  // Warning: Possible null reference

        // ❌ Fix: Check for null before accessing Count
        if (list != null)
        {
            Console.WriteLine(list.Count);
        }

        // ⚠ Warning: Unused variable
        ArrayList unusedList;

        // ⚠ Warning: Assigned but never used
        ArrayList assignedButUnused = new ArrayList();

        // ✅ Fix: Initialize ArrayList before using
        list = new ArrayList(); 
        list.Add(1);
        list.Add("Hello");
        list.Add(3.14);

        #pragma warning restore CS0618, CS8600, CS8602, CS0168, CS0219  // Restore warnings

        // Display the ArrayList contents
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
