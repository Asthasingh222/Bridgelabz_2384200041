using System;

class EmployeeNode {
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
    public EmployeeNode Next;

    public EmployeeNode(int id, string name, string department, double salary) {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
        Next = null;
    }
}

class EmployeeList {
    private EmployeeNode head;

    // ✅ Add Employee at the Beginning
    public void AddAtBeginning(int id, string name, string department, double salary) {
        EmployeeNode newNode = new EmployeeNode(id, name, department, salary);
        newNode.Next = head;
        head = newNode;
    }

    // ✅ Add Employee at the End
    public void AddAtEnd(int id, string name, string department, double salary) {
        EmployeeNode newNode = new EmployeeNode(id, name, department, salary);
        if (head == null) {
            head = newNode;
            return;
        }
        EmployeeNode temp = head;
        while (temp.Next != null) {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // ✅ Add Employee at a Specific Position (0-based index)
    public void AddAtPosition(int id, string name, string department, double salary, int position) {
        if (position < 0) {
            Console.WriteLine("Invalid position.");
            return;
        }

        EmployeeNode newNode = new EmployeeNode(id, name, department, salary);
        if (position == 0) {
            newNode.Next = head;
            head = newNode;
            return;
        }

        EmployeeNode temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++) {
            temp = temp.Next;
        }

        if (temp == null) {
            Console.WriteLine("Position out of range.");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // ✅ Delete Employee by ID
    public void DeleteById(int id) {
        if (head == null) {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.Id == id) {
            head = head.Next;
            return;
        }

        EmployeeNode temp = head;
        while (temp.Next != null && temp.Next.Id != id) {
            temp = temp.Next;
        }

        if (temp.Next == null) {
            Console.WriteLine("Employee not found.");
            return;
        }

        temp.Next = temp.Next.Next;
    }

    // ✅ Search Employee by ID
    public void SearchById(int id) {
        EmployeeNode temp = head;
        while (temp != null) {
            if (temp.Id == id) {
                Console.WriteLine("Employee Found: {0}, {1}, {2}, ${3}",temp.Id,temp.Name,temp.Department,temp.Salary);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Employee not found.");
    }

    // ✅ Search Employee by Name
    public void SearchByName(string name) {
        EmployeeNode temp = head;
        while (temp != null) {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Employee Found: {0}, {1}, {2}, ${3}",temp.Id,temp.Name,temp.Department,temp.Salary);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Employee not found.");
    }

    // ✅ Display all Employee Records
    public void DisplayAll() {
        if (head == null) {
            Console.WriteLine("No employees in the list.");
            return;
        }

        EmployeeNode temp = head;
        Console.WriteLine("\nEmployee Records:");
        while (temp != null) {
            Console.WriteLine("ID: {0}, Name: {1}, Dept: {2}, Salary: ${3}",temp.Id,temp.Name,temp.Department,temp.Salary);
            temp = temp.Next;
        }
    }
}

// ✅ Main Program
class Program {
    public static void Main() {
        EmployeeList employeeList = new EmployeeList();

        // Add employees
        employeeList.AddAtEnd(101, "Ashish", "HR", 50000);
        employeeList.AddAtEnd(102, "Manik", "IT", 60000);
        employeeList.AddAtBeginning(103, "Charlie", "Finance", 55000);
        employeeList.AddAtPosition(104, "Divya", "Marketing", 58000, 2);

        // Display all records
        employeeList.DisplayAll();

        // Search for an employee
        Console.WriteLine("\nSearching for Employee ID 102...");
        employeeList.SearchById(102);

        Console.WriteLine("\nSearching for Employee named 'Charlie'...");
        employeeList.SearchByName("Charlie");

        // Delete an employee
        Console.WriteLine("\nDeleting Employee with ID 103...");
        employeeList.DeleteById(103);

        // Display all records after deletion
        employeeList.DisplayAll();
    }
}
