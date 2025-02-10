using System;
using System.Collections.Generic;

// Abstract class representing a bank account
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    protected double balance; // Protected to allow access in subclasses

    public BankAccount(string accNumber, string holder, double initialBalance)
    {
        this.accountNumber = accNumber;
        this.holderName = holder;
        this.balance = initialBalance;
    }

    // Encapsulation: Getter methods instead of properties
    public string GetAccountNumber() { return accountNumber; }
    public string GetHolderName() { return holderName; }
    public double GetBalance() { return balance; }

    // Methods to deposit and withdraw
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine(holderName + " deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine(holderName + " withdrew: " + amount);
        }
        else
        {
            Console.WriteLine(holderName + " has insufficient balance!");
        }
    }

    // Abstract method for interest calculation
    public abstract double CalculateInterest();
}

// Interface for loanable accounts
interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Savings Account (with interest)
class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string accNumber, string holder, double balance)
        : base(accNumber, holder, balance) { }

    public override double CalculateInterest()
    {
        return balance * 0.04; // 4% annual interest
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine(GetHolderName() + " applied for a loan of: " + amount);
    }

    public double CalculateLoanEligibility()
    {
        return balance * 2; // Loan eligibility is twice the balance
    }
}

// Current Account (no interest)
class CurrentAccount : BankAccount
{
    public CurrentAccount(string accNumber, string holder, double balance)
        : base(accNumber, holder, balance) { }

    public override double CalculateInterest()
    {
        return 0; // No interest on current accounts
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        // Creating accounts
        SavingsAccount savingsAcc = new SavingsAccount("S123", "Anushka", 5000);
        CurrentAccount currentAcc = new CurrentAccount("C456", "Bhavya", 10000);

        accounts.Add(savingsAcc);
        accounts.Add(currentAcc);

        foreach (BankAccount acc in accounts)
        {
            Console.WriteLine("Account: " + acc.GetAccountNumber() + ", Holder: " + acc.GetHolderName());
            Console.WriteLine("Balance: " + acc.GetBalance());
            Console.WriteLine("Interest: " + acc.CalculateInterest());

            // Perform deposit and withdraw operations
            acc.Deposit(2000); // Depositing 2000
            acc.Withdraw(3000); // Withdrawing 3000

            Console.WriteLine("Updated Balance: " + acc.GetBalance());

            // Check for loan eligibility
            if (acc is ILoanable)
            {
                ILoanable loanable = (ILoanable)acc;
                Console.WriteLine("Loan Eligibility: " + loanable.CalculateLoanEligibility());
                loanable.ApplyForLoan(5000); // Applying for a loan of 5000
            }

            Console.WriteLine("------------------------");
        }
    }
}
