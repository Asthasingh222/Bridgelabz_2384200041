using System;
using System.Collections.Generic;
using System.Linq;

// Class to manage the voting system
class VotingSystem
{
    private Dictionary<string, int> votes = new Dictionary<string, int>(); // Store votes with candidate names as keys
    private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(); // Store votes in sorted order
    private LinkedList<string> voteOrder = new LinkedList<string>(); // Maintain the order of votes cast

    // Method to cast a vote for a candidate
    public void CastVote(string candidate)
    {
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++; // Increment vote count
            sortedVotes[candidate]++; // Update sorted dictionary
        }
        else
        {
            votes[candidate] = 1; // Initialize vote count
            sortedVotes[candidate] = 1;
            voteOrder.AddLast(candidate); // Maintain vote order
        }
    }

    // Display vote results in the original order of voting
    public void DisplayResults()
    {
        Console.WriteLine("Vote Results (Original Order):");
        foreach (var candidate in voteOrder.Distinct()) // Ensure unique candidates are displayed once
        {
            Console.WriteLine(candidate + ": " + votes[candidate] + " votes");
        }
    }

    // Display vote results sorted by candidate name
    public void DisplaySortedResults()
    {
        Console.WriteLine("Vote Results (Sorted Order):");
        foreach (var entry in sortedVotes)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value + " votes");
        }
    }
}

// Main program to test the voting system
class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        // Casting votes for different candidates
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");

        // Display results in original order
        votingSystem.DisplayResults();
        Console.WriteLine();
        
        // Display results in sorted order
        votingSystem.DisplaySortedResults();
    }
}
