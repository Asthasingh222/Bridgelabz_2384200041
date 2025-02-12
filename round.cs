using System;

class ProcessNode
{
    public int processId;
    public int burstTime;
    public int priority;
    public int remainingTime;
    public ProcessNode next;

    public ProcessNode(int processId, int burstTime, int priority)
    {
        this.processId = processId;
        this.burstTime = burstTime;
        this.priority = priority;
        this.remainingTime = burstTime;
        this.next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head = null;
    private int timeQuantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    // Add process at the end of circular list
    public void AddProcess(int processId, int burstTime, int priority)
    {
        ProcessNode newNode = new ProcessNode(processId, burstTime, priority);

        if (head == null)
        {
            head = newNode;
            head.next = head; // Circular link
        }
        else
        {
            ProcessNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newNode;
            newNode.next = head;
        }
    }

    // Remove process by process ID
    private void RemoveProcess(int processId)
    {
        if (head == null)
            return;

        ProcessNode temp = head, prev = null;

        // If head is to be deleted
        if (head.processId == processId)
        {
            // Single process case
            if (head.next == head)
            {
                head = null;
                return;
            }

            while (temp.next != head)
                temp = temp.next;

            head = head.next;
            temp.next = head;
            return;
        }

        // Search for the process
        do
        {
            prev = temp;
            temp = temp.next;

            if (temp.processId == processId)
            {
                prev.next = temp.next;
                return;
            }
        } while (temp != head);
    }

    // Simulate Round Robin Scheduling
    public void ExecuteProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to execute.");
            return;
        }

        int time = 0;
        int totalProcesses = 0;
        float totalWaitingTime = 0, totalTurnaroundTime = 0;

        ProcessNode temp = head;
        do { totalProcesses++; temp = temp.next; } while (temp != head);

        Console.WriteLine("\n🔄 Round Robin Execution:");
        while (head != null)
        {
            temp = head;
            do
            {
                if (temp.remainingTime > 0)
                {
                    int execTime = Math.Min(timeQuantum, temp.remainingTime);// [min(3,10) ->3],[min(3,5)->3],[min(3,8)->3]...
                    temp.remainingTime -= execTime; // 10-3 =7 ,5-3=2
                    time += execTime; //3, 3+4=7
                    Console.WriteLine("Process {0} executed for {1} units. Remaining: {2}",temp.processId,execTime,temp.remainingTime);

                    // If process finished execution
                    if (temp.remainingTime == 0)
                    {
                        int turnaroundTime = time;
                        int waitingTime = turnaroundTime - temp.burstTime;
                        totalWaitingTime += waitingTime;
                        totalTurnaroundTime += turnaroundTime;

                        Console.WriteLine(" Process {0} completed. Turnaround Time: {1}, Waiting Time: {2}",temp.processId,turnaroundTime,waitingTime);

                        // Remove the process
                        RemoveProcess(temp.processId);
                    }
                }
                temp = temp.next;
            } while (temp != head);
        }

        // Calculate & display average waiting time and turnaround time
        Console.WriteLine("\n📊 Scheduling Summary:");
        Console.WriteLine("Average Waiting Time: {0:F2}",totalWaitingTime / totalProcesses);
        Console.WriteLine("Average Turnaround Time: {0:F2}",totalTurnaroundTime / totalProcesses);
    }

    // Display list of processes
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Console.WriteLine("\n🔹 Current Process Queue:");
        ProcessNode temp = head;
        do
        {
            Console.WriteLine("Process ID: {0}, Burst Time: {1}, Priority: {2}, Remaining: {3}",temp.processId,temp.burstTime,temp.priority,temp.remainingTime);
            temp = temp.next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(timeQuantum: 3);

        // Add processes
        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 3);
        scheduler.AddProcess(4, 6, 1);

        // Display the initial queue
        scheduler.DisplayProcesses();

        // Execute processes
        scheduler.ExecuteProcesses();
    }
}
