using System;
using System.Collections.Generic;

class Program
{
    static void GenerateBinaryNumbers(int N)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1"); //1

        for (int i = 0; i < N; i++)
        {
            string binary = queue.Dequeue(); //1 10 11 100
            Console.Write(binary + " "); //1 10 11 100

            queue.Enqueue(binary + "0"); // 10 100 110
            queue.Enqueue(binary + "1"); //10 11 101 111
        }
    }

    static void Main()
    {
        int N = 5;
        GenerateBinaryNumbers(N);
    }
}
