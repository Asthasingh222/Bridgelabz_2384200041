using System;

// Base class: BankAccount
public class BankAccount
{
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Account Number: {0}, Balance: {1:C}",AccountNumber,Balance);
    }
}

// Subclass: SavingsAccount (inherits from BankAccount)
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; private set; }

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        base.DisplayAccountType();
        Console.WriteLine("Account Type: Savings, Interest Rate: {0}%",InterestRate);
    }
}

// Subclass: CheckingAccount (inherits from BankAccount)
public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; private set; }

    public CheckingAccount(int accountNumber, double balance, double limit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = limit;
    }

    public override void DisplayAccountType()
    {
        base.DisplayAccountType();
        Console.WriteLine("Account Type: Checking, Withdrawal Limit: {0:C}",WithdrawalLimit);
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount(1001, 5000, 3.5);
        CheckingAccount checking = new CheckingAccount(1002, 2000, 1000);

        savings.DisplayAccountType();
        Console.WriteLine();
        checking.DisplayAccountType();
    }
}
