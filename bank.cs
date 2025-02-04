using System;

public class BankAccount
{
    // Static field to hold the bank name
    private static string bankName = "HDFC Bank";
    
    // Static field to track the total number of accounts
    private static int totalAccounts = 0;

    // Instance fields
    private string accountHolder;
    private readonly int accountNumber;
    private decimal accBalance;

    // Property to get bank name 
    {
        return bankName;
    }

    // Property to get account number 
    public int GetAccountNumber()
    {
        return accountNumber;
    }

    // Property to get account holder
    public string GetAccountHolder()
    {
        return accountHolder;
    }

    // Property to get account balance
    public decimal GetAccBalance()
    {
        return accBalance;
    }

    // Constructor to initialize the bank account
    public BankAccount(int accountNumber, string accountHolder, decimal accBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.accBalance = accBalance;
        totalAccounts++; // Increment the total accounts count
    }

    // Static method to get the total number of bank accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Number of accounts: " + totalAccounts);
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Bank Name: " + GetBankName() + ", Account Number: " + GetAccountNumber() +
                          ", Account Holder: " + GetAccountHolder() + ", Account Balance: " + GetAccBalance());
    }
}

public class Program
{
    public static void Main()
    {
        // Create first bank account object
        BankAccount Bank1 = new BankAccount(12345, "Astha Singh Jadon", 1500);

        // Display account details if Bank1 is an instance of BankAccount
        if (Bank1 is BankAccount)
        {
            Bank1.DisplayAccountDetails();
        }

        // Display total accounts count
        BankAccount.GetTotalAccounts();

        // Create second bank account object
        BankAccount Bank2 = new BankAccount(23456, "Jyoti Saraswat", 2500);

        // Display account details if Bank2 is an instance of BankAccount
        if (Bank2 is BankAccount)
        {
            Bank2.DisplayAccountDetails();
        }

        // Display total accounts count again after adding Bank2
        BankAccount.GetTotalAccounts();
    }
}
