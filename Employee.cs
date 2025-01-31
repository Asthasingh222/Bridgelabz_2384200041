using System;

    // Employee class with attributes and methods
    class Employee
    {
        // Private attributes
        private string name;
        private int id;
        private double salary;

        // Constructor to initialize employee details
        public Employee(string empName, int empId, double empSalary)
        {
            name = empName;
            id = empId;
            salary = empSalary;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an Employee object
            Employee emp = new Employee("John Doe", 101, 50000);

            // Displaying Employee details
            emp.DisplayDetails();
        }
    }
