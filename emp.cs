using System;

public class Employee
{
    public int employeeID;  // Public
    protected string department; // Protected
    private double salary; // Private

    // Constructor
    public Employee(int id, string dept, double sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Public Method to Modify Salary
    public void SetSalary(double newSalary)
    {
        salary = newSalary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

// Subclass accessing protected and public members
public class Manager : Employee
{
    public Manager(int id, string dept, double sal) : base(id, dept, sal) { }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Manager ID: " + employeeID + ", Department: " + department);
    }
}

public class Program
{
    public static void Main()
    {
        Manager manager = new Manager(1001, "IT", 60000);
        manager.DisplayEmployeeDetails();
        Console.WriteLine("Salary: " + manager.GetSalary());
        manager.SetSalary(65000);
        Console.WriteLine("Updated Salary: " + manager.GetSalary());
    }
}
