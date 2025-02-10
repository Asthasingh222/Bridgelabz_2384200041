using System;
using System.Collections.Generic;

// Abstract class representing an Employee
abstract class Employee
{
    protected int employeeId;
    protected string name;
    protected int baseSalary;

    // Abstract method to calculate salary, implemented in derived classes
    public abstract double CalculateSalary();

    // Constructor to initialize employee details
    public Employee(int id, string name, int salary)
    {
        employeeId = id;
        this.name = name;
        baseSalary = salary;
    }

    // Method to display employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Employee Id: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + CalculateSalary());
    }
}

// Interface for handling department assignments
interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Full-time employee class inheriting from Employee and implementing IDepartment
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    // Constructor for FullTimeEmployee
    public FullTimeEmployee(int id, string name, int salary) : base(id, name, salary) { }

    // Returns the fixed salary for full-time employees
    public override double CalculateSalary()
    {
        return baseSalary;
    }

    // Assigns department to the employee
    public void AssignDepartment(string dep)
    {
        this.department = dep;
    }

    // Retrieves department details
    public string GetDepartmentDetails()
    {
        return "Department: " + (department ?? "Not Assigned");
    }

    // Displays employee details along with department info
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

// Part-time employee class inheriting from Employee and implementing IDepartment
class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int workHours;
    private double hourlyRate;

    // Constructor for PartTimeEmployee
    public PartTimeEmployee(int id, string name, int workHours, double hourlyRate)
        : base(id, name, 0) // Base salary is not fixed for part-time employees
    {
        this.workHours = workHours;
        this.hourlyRate = hourlyRate;
    }

    // Calculates salary based on hours worked and hourly rate
    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
    }

    // Assigns department to the employee
    public void AssignDepartment(string dep)
    {
        this.department = dep;
    }

    // Retrieves department details
    public string GetDepartmentDetails()
    {
        return "Department: " + (department ?? "Not Assigned");
    }

    // Displays employee details along with department info
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

// Main program class
class Program
{
    public static void Main(string[] args)
    {
        // Create a list of employees
        List<Employee> employees = new List<Employee>();
        
        // Adding a full-time employee
        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Manya", 50000);
        emp1.AssignDepartment("HR");
        employees.Add(emp1);

        // Adding a part-time employee
        PartTimeEmployee emp2 = new PartTimeEmployee(102, "Nupur", 120, 100);
        emp2.AssignDepartment("IT"); // Correctly assigning department to emp2
        employees.Add(emp2);

        // Iterating through the list and displaying employee details
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine("------------------------");
        }
    }
}