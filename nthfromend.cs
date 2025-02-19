using System;
using System.Collections.Generic;

class Program
{
    // Function to find the Nth element from the last in a linked list
    static string NthElementFromLast(LinkedList<string> s, int n)
    {
        LinkedListNode<string> slow = s.First; // Slow pointer starts at the head
        LinkedListNode<string> fast = s.First; // Fast pointer starts at the head
        int cnt = n;

        // Move the fast pointer `n` steps ahead
        while (cnt > 0)
        {
            if (fast == null)  // If `n` is greater than the list length, return an error
            {
                return "N is greater than the length of the list.";
            }
            fast = fast.Next;
            cnt--;
        }

        // Move both fast and slow pointers one step at a time
        // When fast reaches the end, slow will be at the Nth node from the last
        while (fast != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow.Value; // Return the Nth node from the end
    }

    // Function to display the linked list
    static void DisplayList(LinkedList<string> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " -> ");
        }
        Console.WriteLine("null");
    }

    public static void Main()
    {
        // Create a linked list with elements A, B, C, D, E
        LinkedList<string> l = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });

        // Display the original list
        DisplayList(l);

        int n = 2; // Find the 2nd element from the last

        // Print the Nth element from the end
        Console.WriteLine("Nth Element from last when n={0}: {1}", n, NthElementFromLast(l, n));
    }
}
