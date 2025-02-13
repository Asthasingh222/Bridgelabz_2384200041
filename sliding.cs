using System;
using System.Collections.Generic;

class SlidingWindowMax {
    public static int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 0) return new int[0];

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>(); // Stores indices

        for (int i = 0; i < nums.Length; i++) {
            // Remove elements that are out of this window
            if (deque.Count > 0 && deque.First.Value < i - k + 1) {
                deque.RemoveFirst();
            }

            // Remove all smaller elements in the window
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i]) {
                deque.RemoveLast();
            }

            // Add current element at the end
            deque.AddLast(i);

            // Append the maximum element for valid windows (from index k-1 onwards)
            if (i >= k - 1) {
                result.Add(nums[deque.First.Value]);
            }
        }
        return result.ToArray();
    }

    public static void Main() {
        int[] nums = {1, 3, -1, -3, 5, 3, 6, 7};
        int k = 3;
        int[] maxValues = MaxSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximum:");
        Console.WriteLine(string.Join(" ", maxValues)); // Output: 3 3 5 5 6 7
    }
}
