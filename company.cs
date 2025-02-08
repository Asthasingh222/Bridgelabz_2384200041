using System;
using System.Collections.Generic;

// Employee class exists inside a Department
class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Employee: {0}",Name);
    }
}

// Department class contains Employees, exists only inside Company
class Department
{
    public string Name { get; private set; }
    public List<Employee> Employees { get; set; }

    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee); // Employees belong to a specific department
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("Department: {0}",Name);
        foreach (var employee in Employees)
        {
            employee.Display();
        }
    }
}

// Company class contains Departments, ensuring composition (when Company is deleted, so are its departments)
class Company
{
    public string Name { get; set; }
    public List<Department> Departments { get; private set; }

    public Company(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void DisplayCompanyStructure()
    {
        Console.WriteLine("Company: {0}",Name);
        foreach (var department in Departments)
        {
            department.DisplayEmployees();
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating a company
        Company company = new Company("Capgemini");

        // Creating departments
        Department dept1 = new Department("Engineering");
        Department dept2 = new Department("HR");

        // Adding employees to departments
        dept1.AddEmployee(new Employee("Rohan"));
        dept1.AddEmployee(new Employee("Ramya"));
        dept2.AddEmployee(new Employee("Charu"));

        // Adding departments to company
        company.AddDepartment(dept1);
        company.AddDepartment(dept2);

        // Displaying company structure
        company.DisplayCompanyStructure();
    }
}
