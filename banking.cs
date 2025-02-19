using System;
using System.Collections.Generic;
using System.Linq;

// Class to manage the banking system
class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Store account balances
    private SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>(); // Sort customers by balance
    private Queue<int> withdrawalQueue = new Queue<int>(); // Process withdrawal requests

    // Method to add an account
    public void AddAccount(int accountNumber, double balance)
    {
        if (!accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] = balance;
            sortedAccounts[accountNumber] = balance;
        }
    }

    // Method to process withdrawals
    public void RequestWithdrawal(int accountNumber)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            withdrawalQueue.Enqueue(accountNumber);
        }
    }

    // Process queued withdrawals
    public void ProcessWithdrawals()
    {
        while (withdrawalQueue.Count > 0)
        {
            int accountNumber = withdrawalQueue.Dequeue();
            Console.WriteLine("Processing withdrawal for Account: " + accountNumber);
        }
    }

    // Display accounts sorted by balance
    public void DisplaySortedAccounts()
    {
        Console.WriteLine("Accounts sorted by balance:");
        foreach (var account in sortedAccounts.OrderBy(a => a.Value))
        {
            Console.WriteLine("Account " + account.Key + ": Balance $" + account.Value);
        }
    }
}

// Main program to test the banking system
class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();
        bank.AddAccount(1001, 5000.00);
        bank.AddAccount(1002, 3000.00);
        bank.AddAccount(1003, 7000.00);
        
        bank.RequestWithdrawal(1001);
        bank.RequestWithdrawal(1002);
        
        // Process withdrawals
        bank.ProcessWithdrawals();
        Console.WriteLine();
        
        // Display sorted accounts
        bank.DisplaySortedAccounts();
    }
}