using System;

public class Employee
{
    private static string companyName = "Capgemini";
    private static int numberOfEmployees = 0;
    private readonly int id;
    private string name;
    private string designation;

    // Static method to get company name
    public static string GetCompanyName()
    {
        return companyName;
    }

    // Getter methods for private fields
    public int GetID() { return id; }
    public string GetName() { return name; }
    public string GetDesignation() { return designation; }

    // Constructor
    public Employee(string name, int id, string designation)
    {
        this.id = id;
        this.name = name;
        this.designation = designation;
        numberOfEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Number of Employees: " + numberOfEmployees);
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Company Name: " + GetCompanyName() + ", Employee ID: " + GetID() +
                          ", Name: " + GetName() + ", Designation: " + GetDesignation());
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp1 = new Employee("Astha Singh", 123, "Software Engineer");
        if (emp1 is Employee) emp1.DisplayEmployeeDetails();
        Employee.DisplayTotalEmployees();

        Employee emp2 = new Employee("Nistha Sharma", 456, "CA");
        if (emp2 is Employee) emp2.DisplayEmployeeDetails();
        Employee.DisplayTotalEmployees();
    }
}
