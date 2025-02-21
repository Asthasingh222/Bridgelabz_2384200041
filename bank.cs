using System;

// Custom exception for insufficient funds
class InsufficientFundsException : Exception
{
    public double Amount { get;set; } // Property to store shortfall amount

    public InsufficientFundsException(string message, double amount) : base(message)
    {
        Amount = amount;
    }
}

class BankAccount
{
    private double balance;

    // Constructor to initialize balance
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Withdraw method with exception handling
    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!"); // Throws for negative amount
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!", amount - balance); // Throws if insufficient funds
        }
        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: $" + balance);
    }

    // Get balance
    public double GetBalance()
    {
        return balance;
    }

    static void Main()
    {
        BankAccount account = new BankAccount(100.0);

        try
        {
            Console.WriteLine("Depositing $50...");
            account.Deposit(50.0);
            Console.WriteLine("New balance: $" + account.GetBalance());

            Console.Write("Enter withdrawal amount: ");
            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(withdrawalAmount);
        }
        catch (ArgumentException e) // Handle negative withdrawal
        {
            Console.WriteLine(e.Message);
        }
        catch (InsufficientFundsException e) // Handle insufficient funds
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Shortfall: $" + e.Amount);
        }
    }
}
