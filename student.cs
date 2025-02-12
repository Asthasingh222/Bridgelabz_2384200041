using System;

// Class representing a single student node in the linked list
class StudentNode{
    public int rollno;
    public string name;
    public int age;
    public char grade;
    public StudentNode next; // Pointer to the next student node
    
    // Constructor to initialize student details
    public StudentNode(int roll, string name, int age, char grade){
        rollno = roll;
        this.name = name;
        this.age = age;
        this.grade = grade;
        next = null; // Initially, next is null
    }
}

// Class representing the linked list of students
class StudentList{
    private StudentNode head; // Head node of the linked list

    // Add a student at the beginning of the list
    public void AddAtBeginning(int roll, string name, int age, char grade){
        StudentNode student = new StudentNode(roll, name, age, grade);
        student.next = head; // New student points to the previous head
        head = student; // Update head to the new student
    }

    // Add a student at the end of the list
    public void AddAtEnd(int roll, string name, int age, char grade){
        StudentNode student = new StudentNode(roll, name, age, grade);
        if (head == null){ // If list is empty, make the new student the head
            head = student;
            return;
        }
        StudentNode temp = head;
        while (temp.next != null){ // Traverse to the last node
            temp = temp.next;
        }
        temp.next = student; // Add new student at the end
    }

    // Add a student at a specific position in the list
    public void AddAtPosition(int roll, string name, int age, char grade, int pos){
        if (pos < 0) {
            Console.WriteLine("Invalid position");
            return;
        }
        StudentNode student = new StudentNode(roll, name, age, grade);
        if (pos == 0){ // If position is 0, insert at beginning
            student.next = head;
            head = student;
            return;
        }
        StudentNode temp = head;
        while (temp != null && pos > 1){ // Traverse to the required position
            temp = temp.next;
            pos--;
        }
        if (temp == null) {
            Console.WriteLine("Position out of range.");
            return;
        }
        student.next = temp.next; // Insert new node at the position
        temp.next = student;
    }
    
    // Delete a student by roll number
    public void DeleteStudentByRoll(int roll){
        if (head == null){
            Console.WriteLine("Student List is Empty.");
            return;
        }
        if (head.rollno == roll){ // If head node is the target
            head = head.next;
            Console.WriteLine("Student with Roll Number {0} is deleted", roll);
            return;
        }
        StudentNode temp = head;
        while (temp.next != null && temp.next.rollno != roll){ // Find target node
            temp = temp.next;
        }
        if (temp.next == null){
            Console.WriteLine("Student not found");
            return;
        }
        temp.next = temp.next.next; // Remove the target node
        Console.WriteLine("Student with Roll Number {0} is deleted", roll);
    }

    // Search for a student by roll number
    public void SearchStudentByRoll(int roll){
        if (head == null){
            Console.WriteLine("Student List is Empty.");
            return;
        }
        StudentNode temp = head;
        while (temp != null && temp.rollno != roll){ // Traverse the list
            temp = temp.next;
        }
        if (temp == null){
            Console.WriteLine("Student with roll no. {0} is not found", roll);
            return;
        }
        Console.WriteLine("Student with Roll Number {0} is found", roll);
        Console.WriteLine("Name: {0} \n Roll no.: {1} \n Age: {2} \n Grade: {3}", temp.name, temp.rollno, temp.age, temp.grade);
    }

    // Display all student records
    public void DisplayRecords(){
        if (head == null){
            Console.WriteLine("Student List is Empty.");
            return;
        }
        StudentNode temp = head;
        while (temp != null){ // Traverse the list
            Console.WriteLine("Name: {0} \n Roll no.: {1} \n Age: {2} \n Grade: {3}", temp.name, temp.rollno, temp.age, temp.grade);
            Console.WriteLine("---------------------------");
            temp = temp.next;
        }
    }

    // Update a student's grade based on their roll number
    public void UpdateGrade(int roll, char gr){
        if (head == null){
            Console.WriteLine("Student List is Empty.");
            return;
        }
        StudentNode temp = head;
        while (temp != null && temp.rollno != roll){ // Traverse the list
            temp = temp.next;
        }
        if (temp == null){
            Console.WriteLine("Student not found");
            return;
        }
        temp.grade = gr; // Update the grade
        Console.WriteLine("Grade of student with Roll no. {0} is updated to {1}", roll, temp.grade);
    }
}

// Main class to test the linked list operations
class Program{
    public static void Main(string[] args){
        StudentList list = new StudentList();
        list.AddAtBeginning(101, "Astha", 22, 'A'); // Astha
        list.AddAtEnd(102, "Anushka", 25, 'B'); // Astha->Anushka
        list.AddAtBeginning(103, "Kanishka", 28, 'C'); //Kanishka ->Astha ->Anushka
        list.AddAtEnd(108, "Manya", 40, 'D'); //Kanishka ->Astha ->Anushka ->Manya
        list.AddAtPosition(104, "Laksh", 34, 'A', 2); //Kanishka ->Astha ->Laksh ->Anushka ->Manya
        
        list.DisplayRecords();
        
        list.DeleteStudentByRoll(104);
        Console.WriteLine("Updated List: "); //Kanishka ->Astha ->Anushka ->Manya
        list.DisplayRecords();
        
        list.SearchStudentByRoll(108); //Manya
        Console.WriteLine("-------------------------------");
        list.SearchStudentByRoll(104); //Not found
        Console.WriteLine("-------------------------------");
        list.UpdateGrade(101, 'B');
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Updated List: ");
        list.DisplayRecords();
    }
}
