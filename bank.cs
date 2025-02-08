using System;
using System.Collections.Generic;

// Bank class that manages customers
class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }

    public Bank(string name)
    {
        Name = name;
        Customers= new List<Customer>();
    }

    public void OpenAccount(Customer customer)
    {
        Customers.Add(customer); // Associating a customer with the bank
        Console.WriteLine("{0} opened an account in {1}",customer.Name,Name);
    }
}

// Customer class associated with a Bank
class Customer
{
    public string Name { get; set; }
    public double Balance { get; private set; }

    public Customer(string name, double initialBalance)
    {
        Name = name;
        Balance = initialBalance;
    }

    public void ViewBalance()
    {
        Console.WriteLine("{0} has a balance of {1} Rs.",Name,Balance);
    }
}

class Program
{
    static void Main()
    {
        // Creating a bank
        Bank bank = new Bank("National Bank");

        // Creating customers
        Customer customer1 = new Customer("Astha", 5000);
        Customer customer2 = new Customer("Nistha", 3000);

        // Opening accounts for customers
        bank.OpenAccount(customer1);
        bank.OpenAccount(customer2);

        // Viewing balances
        customer1.ViewBalance();
        customer2.ViewBalance();
    }
}
