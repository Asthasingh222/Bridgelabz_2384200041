using System;
using System.Collections.Generic;

class Program
{
    static void ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        // Step 1: Dequeue elements from queue and push them onto the stack
        while (queue.Count > 0)
            stack.Push(queue.Dequeue());

        // Step 2: Pop elements from stack and enqueue them back into the queue
        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 10, 20, 30 });

        ReverseQueue(queue);

        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
}
