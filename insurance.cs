using System;
using System.Collections.Generic;
using System.Linq;

// Class representing an insurance policy
class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; set; } // Unique policy number
    public string CoverageType { get; set; } // Type of coverage
    public DateTime ExpiryDate { get; set; } // Expiry date of the policy

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    // Override Equals method to compare policies by PolicyNumber
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Policy policy = (Policy)obj;
        return PolicyNumber == policy.PolicyNumber;
    }

    // Override GetHashCode to return hash based on PolicyNumber
    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    // Compare policies by expiry date for SortedSet
    public int CompareTo(Policy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }
}

// Class to manage insurance policies
class InsurancePolicyManager
{
    private HashSet<Policy> policySet = new HashSet<Policy>(); // Unique policies
    private LinkedList<Policy> orderedPolicies = new LinkedList<Policy>(); // Maintain insertion order
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(); // Policies sorted by expiry date
    private Dictionary<string, int> policyCounts = new Dictionary<string, int>(); // Track duplicate policies

    // Add a new policy
    public void AddPolicy(Policy policy)
    {
        if (policySet.Add(policy))
        {
            orderedPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }

        if (policyCounts.ContainsKey(policy.PolicyNumber))
            policyCounts[policy.PolicyNumber]++;
        else
            policyCounts[policy.PolicyNumber] = 1;
    }

    // Retrieve all unique policies
    public IEnumerable<Policy> GetAllPolicies()
    {
        return policySet;
    }

    // Retrieve policies expiring within the next 30 days
    public IEnumerable<Policy> GetExpiringSoonPolicies()
    {
        DateTime threshold = DateTime.Now.AddDays(30);
        return sortedPolicies.Where(p => p.ExpiryDate <= threshold);
    }

    // Retrieve policies based on coverage type
    public IEnumerable<Policy> GetPoliciesByCoverageType(string coverageType)
    {
        return policySet.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase));
    }

    // Retrieve duplicate policies based on policy numbers
    public IEnumerable<Policy> GetDuplicatePolicies()
    {
        return policySet.Where(p => policyCounts[p.PolicyNumber] > 1);
    }
}

// Main program to test the InsurancePolicyManager
class Program
{
    static void Main()
    {
        InsurancePolicyManager manager = new InsurancePolicyManager();
        manager.AddPolicy(new Policy("P123", "Health", DateTime.Now.AddDays(10)));
        manager.AddPolicy(new Policy("P124", "Auto", DateTime.Now.AddDays(40)));
        manager.AddPolicy(new Policy("P125", "Home", DateTime.Now.AddDays(20)));
        manager.AddPolicy(new Policy("P123", "Health", DateTime.Now.AddDays(10))); // Duplicate

        Console.WriteLine("All Policies:");
        foreach (var policy in manager.GetAllPolicies())
            Console.WriteLine(policy.PolicyNumber);

        Console.WriteLine("\nExpiring Soon:");
        foreach (var policy in manager.GetExpiringSoonPolicies())
            Console.WriteLine(policy.PolicyNumber);

        Console.WriteLine("\nPolicies with Coverage Type 'Health':");
        foreach (var policy in manager.GetPoliciesByCoverageType("Health"))
            Console.WriteLine(policy.PolicyNumber);

        Console.WriteLine("\nDuplicate Policies:");
        foreach (var policy in manager.GetDuplicatePolicies())
            Console.WriteLine(policy.PolicyNumber);
    }
}