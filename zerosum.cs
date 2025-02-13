using System;
using System.Collections.Generic;

class ZeroSumSubarrays {
    public static void FindZeroSumSubarrays(int[] nums) {
        Dictionary<int, int> sumIndices = new Dictionary<int, int>(); // Stores sum → first index
        int sum = 0;

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i]; // Compute cumulative sum

            // If sum is zero, subarray exists from index 0 to i
            if (sum == 0) {
                Console.WriteLine("Subarray found from index 0 to {0}",i);
            }

            // If sum was seen before, a zero-sum subarray exists
            if (sumIndices.ContainsKey(sum)) {
                int start = sumIndices[sum] + 1;
                Console.WriteLine("Subarray found from index {0} to {1}",start,i);
            } else {
                // Store first occurrence of sum
                sumIndices[sum] = i;
            }
        }
    }

    public static void Main(string[] args) {
        int[] nums = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
        Console.WriteLine("Zero-sum subarrays:");
        FindZeroSumSubarrays(nums);
    }
}
