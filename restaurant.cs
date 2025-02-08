using System;

// Base class: Person
public class Person
{
    protected string Name;
    protected int Id;

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
    }
}

// Interface: Worker
public interface Worker
{
    void PerformDuties();
}

// Subclass: Chef (inherits from Person, implements Worker)
public class Chef : Person, Worker
{
    public Chef(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Role: Chef");
        Console.WriteLine("Duties: Cooking and managing kitchen.");
    }
}

// Subclass: Waiter (inherits from Person, implements Worker)
public class Waiter : Person, Worker
{
    public Waiter(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Role: Waiter");
        Console.WriteLine("Duties: Serving customers and taking orders.");
    }
}

class Program
{
    static void Main()
    {
        Chef chef = new Chef("Jaya", 101);
        Waiter waiter = new Waiter("Priya", 102);

        chef.DisplayInfo();
        chef.PerformDuties();
        Console.WriteLine();
        
        waiter.DisplayInfo();
        waiter.PerformDuties();
    }
}
