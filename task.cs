using System;

class TaskNode
{
    public int taskId;
    public string name;
    public int priority;
    public string dueDate;
    public TaskNode next;

    public TaskNode(int taskId, string name, int priority, string dueDate)
    {
        this.taskId = taskId;
        this.name = name;
        this.priority = priority;
        this.dueDate = dueDate;
        this.next = null;
    }
}

class TaskList
{
    private TaskNode head = null;
    private TaskNode currentTask = null;
    // Add task at the Beginning
    public void AddAtBeginning(int taskId, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(taskId, name, priority, dueDate);
        if (head == null)
        {
            head = newNode;
            head.next = head;  // Circular reference for single node
            currentTask =head;
            return;
        }

        TaskNode last = head;
        while (last.next != head)
        {
            last = last.next;
        }

        newNode.next = head;
        last.next = newNode;
        head = newNode;
    }

    // Add task at the End
    public void AddAtEnd(int taskId, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(taskId, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            head.next = head;  // Self-loop for circular list
             currentTask =head;
            return;
        }

        TaskNode temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }

        temp.next = newNode;
        newNode.next = head;  // Maintain circular linking
    }

    //Remove task by task id
    public void RemoveTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Playlist is empty.");
            return;
        }

        TaskNode temp = head, prev = null;

        //if head node itself holds the id to be deleted
        if (head.taskId == id)
        {
            //if only single node
            if (head.next == head)
            {
                head = null;
                Console.WriteLine("Task removed: {0}", id);
                return;
            }
            while (temp.next != head)
            {
                temp = temp.next;
            }
            head = head.next;
            temp.next = head;
            Console.WriteLine("Task removed: {0}", id);
            return;
        }

        // searching for the the task
        temp = head;
        do
        {
            prev = temp;
            temp = temp.next;
            if (temp.taskId == id)
            {
                prev.next = temp.next;
                if (currentTask.taskId == id)
                    currentTask = temp.next; 
                Console.WriteLine("Deleted:{0}", id);
                return;
            }
        }
        while (temp != head);
        Console.WriteLine("Task not found.");

    }

    // View the current task
    public void ViewCurrentTask()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("\n--- Current Task ---");
        Console.WriteLine("Task ID: {0}, Name: {1}, Priority: {2}, Due Date: {3}",
            currentTask.taskId, currentTask.name, currentTask.priority, currentTask.dueDate);
    }

    // Move to the next task
    public void MoveToNextTask()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        currentTask = currentTask.next;
        Console.WriteLine("Moved to next task.");
        ViewCurrentTask(); // Display the new current task
    }
    //search for a task by priority
    public void SearchByPriority(int priority)
{
    if (head == null)
    {
        Console.WriteLine("Task List is empty.");
        return;
    }

    TaskNode temp = head;

    // Iterate through the circular linked list
    do
    {
        if (temp.priority == priority)
        {
            Console.WriteLine("\nTask with priority {0} found:", priority);
            Console.WriteLine("Task ID: {0}, Name: {1}, Priority: {2}, Due Date: {3}",
                temp.taskId, temp.name, temp.priority, temp.dueDate);
            return; // Exit after finding the first match
        }
        temp = temp.next;
    } while (temp != head); // Ensures we traverse the entire circular list

    // If no match is found, print message after loop
    Console.WriteLine("Task with priority {0} not found.", priority);
}

    // Display all tasks
    public void DisplayTaskList()
    {
        if (head == null)
        {
            Console.WriteLine("Task List is empty.");
            return;
        }

        Console.WriteLine("------- Task List ------");
        TaskNode temp = head;

        do
        {
            Console.WriteLine("Task ID: {0}, Name: {1}, Priority: {2}, Due Date: {3}",
                temp.taskId, temp.name, temp.priority, temp.dueDate);
            temp = temp.next;
        } while (temp != head);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        TaskList taskList = new TaskList();

        // Add tasks
        taskList.AddAtBeginning(101, "Walking", 2, "13-Feb");
        taskList.AddAtEnd(102, "DSA Assignment", 1, "20-Feb");
        taskList.AddAtEnd(103, "CN Assessment", 4, "24-March");

        // Display tasks
        taskList.DisplayTaskList();

        // Delete a task
        Console.WriteLine("\n Deleting task with id 102...");
        taskList.RemoveTask(102);
        taskList.DisplayTaskList();

        Console.WriteLine("\n Searching task with priority 2...");
        taskList.SearchByPriority(2);


        // View the current task
        taskList.ViewCurrentTask();

        // Move to the next task
        taskList.MoveToNextTask();
        taskList.MoveToNextTask(); // Move again to test circular behavior
    }
}
