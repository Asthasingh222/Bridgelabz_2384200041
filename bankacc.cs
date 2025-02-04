using System;

public class BankAccount
{
    public int accountNumber;  // Public
    protected string accountHolder; // Protected
    private double balance; // Private

    // Constructor
    public BankAccount(int accNumber, string holder, double accBalance)
    {
        accountNumber = accNumber;
        accountHolder = holder;
        balance = accBalance;
    }

    // Public Methods to Modify Balance
    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }
}

// Subclass accessing protected and public members
public class SavingsAccount : BankAccount
{
    public SavingsAccount(int accNumber, string holder, double accBalance) : base(accNumber, holder, accBalance) { }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber + ", Account Holder: " + accountHolder);
    }
}

public class Program
{
    public static void Main()
    {
        SavingsAccount savings = new SavingsAccount(12345, "Priya Singh", 500);
        savings.DisplayAccountDetails();
        Console.WriteLine("Balance: " + savings.GetBalance());
        savings.Deposit(200);
        Console.WriteLine("New Balance: " + savings.GetBalance());
    }
}
