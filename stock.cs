using System;
using System.Collections.Generic;

class StockSpan {
    public static int[] CalculateSpan(int[] prices) {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>(); // Stores indices of prices in decreasing order

        for (int i = 0; i < n; i++) {
            // Pop elements from stack while stack is not empty and price at stack top is smaller than current price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i]) {
                stack.Pop();
            }

            // If stack is empty, it means no previous smaller price exists, so span is (i+1)
            if (stack.Count == 0) {
                span[i] = i + 1;
            } else {
                // Else, the span is the difference between current index and top of stack
                span[i] = i - stack.Peek();
            }

            // Push the current index onto stack
            stack.Push(i);
        }
        return span;
    }

    public static void Main() {
        int[] prices = {100, 80, 60, 70, 60, 75, 85};
        int[] spans = CalculateSpan(prices);

        Console.WriteLine("Stock spans:");
        Console.WriteLine(string.Join(" ", spans)); // Output: 1 1 1 2 1 4 6
    }
}
