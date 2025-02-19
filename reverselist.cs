using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Reverse ArrayList
        ArrayList arr = new ArrayList { 1, 2, 3, 4, 5 };
        Console.WriteLine("Reversing ArrayList:");
        ReverseArrayList(arr);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Reverse LinkedList
        LinkedList<int> l = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Original LinkedList:");
        DisplayList(l);

        ReverseLinkedList(l);

        Console.WriteLine("Reversed LinkedList:");
        DisplayList(l);
    }

    static void ReverseArrayList(ArrayList arr)
    {
        int i = 0, j = arr.Count - 1;
        while (i < j)
        {
            object temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
    }

    static void ReverseLinkedList(LinkedList<int> list)
    {
        if (list.Count < 2) return; // No need to reverse if only one element or empty

        LinkedListNode<int> node = list.First;
        while (node.Next != null)
        {
            LinkedListNode<int> next = node.Next;
            list.Remove(next);       // Remove next node
            list.AddFirst(next);     // Insert it at the beginning
        }
    }

    static void DisplayList(LinkedList<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " -> ");
        }
        Console.WriteLine("null");
    }
}
