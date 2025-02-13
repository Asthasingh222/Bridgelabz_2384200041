using System;
using System.Collections.Generic;

class LongestConsecutiveSequenceSolver{
    // Method to find the length of the longest consecutive sequence in an array
    public static int LongestConsecutive(int[] nums){
        if (nums.Length == 0) return 0; 
        
        // Store all elements in a HashSet for O(1) lookups
        HashSet<int> numSet = new HashSet<int>(nums); 
        int longestStreak = 0; // Variable to track the longest sequence found
        
        foreach (int num in numSet){
            // Check if num is the start of a sequence (i.e., num - 1 is not in the set)
            if (!numSet.Contains(num - 1)){ 
                int currentNum = num;
                int currentStreak = 1;
                
                // Continue checking for the next consecutive numbers in the sequence
                while (numSet.Contains(currentNum + 1)){
                    currentNum += 1;
                    currentStreak += 1;
                }
                
                // Update longestStreak if the current sequence is longer
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        
        return longestStreak;
    }
}

class Program{
    public static void Main(string[] args){
    
        int[] nums = {100, 4, 200, 1, 3, 2};
        
        // Compute and print the longest consecutive sequence length
        int longestSequence = LongestConsecutiveSequenceSolver.LongestConsecutive(nums);
        Console.WriteLine("Longest Consecutive Sequence Length: " + longestSequence);
    }
}