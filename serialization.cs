using System;
using System.IO;
using System.Text.Json;

class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public string department { get; set; }
    public int salary { get; set; }

    // Parameterless constructor (required for deserialization)
    public Employee() { }

    public Employee(int id, string name, string department, int salary)
    {
        this.id = id;
        this.name = name;
        this.department = department;
        this.salary = salary;
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "Astha", "Computer Science", 40000);
        string json = JsonSerializer.Serialize(emp1);
        File.WriteAllText("employee.json", json);

        string readJson = File.ReadAllText("employee.json");
        Employee deserializedEmployee = JsonSerializer.Deserialize<Employee>(readJson);

        Console.WriteLine("Deserialized ID: {0}, Name: {1}, Department: {2}, Salary: {3}",
            deserializedEmployee.id, deserializedEmployee.name, deserializedEmployee.department, deserializedEmployee.salary);
    }
}
