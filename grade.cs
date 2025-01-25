using System;

class Program
{
    static void Main()
    {
        // Step 1: Input the number of students
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        // Step 2: Create arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[n];
        int[] chemistryMarks = new int[n];
        int[] mathsMarks = new int[n];
        double[] percentages = new double[n];
        char[] grades = new char[n];

        // Step 3: Take input for marks in Physics, Chemistry, and Maths
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter marks for Student {0}:",i+1);

            physicsMarks[i] = GetValidMarks("Physics");
            chemistryMarks[i] = GetValidMarks("Chemistry");
            mathsMarks[i] = GetValidMarks("Maths");
        }

        // Step 4: Calculate percentages and grades
        for (int i = 0; i < n; i++)
        {
            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
            percentages[i] = (totalMarks / 300.0) * 100; // Assuming each subject has a max of 100 marks

            // Assign grades based on percentage
            if (percentages[i] >= 90)
                grades[i] = 'A';
            else if (percentages[i] >= 80)
                grades[i] = 'B';
            else if (percentages[i] >= 70)
                grades[i] = 'C';
            else if (percentages[i] >= 60)
                grades[i] = 'D';
            else
                grades[i] = 'F';
        }

        // Step 5: Display the marks, percentages, and grades
        Console.WriteLine("\nSummary of Results:");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        Console.WriteLine("----------------------------------------------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4:F2}\t\t{5}",i + 1,physicsMarks[i],chemistryMarks[i],mathsMarks[i],percentages[i],grades[i]);
        }
    }

    // Helper function to get valid marks input
    static int GetValidMarks(string subject)
{
    while (true)
    {
        Console.Write("Enter marks in {0} (0-100): ",subject);
        int marks = int.Parse(Console.ReadLine());
        if (marks >= 0 && marks <= 100)
            return marks;

        Console.WriteLine("Invalid marks. Please enter a value between 0 and 100.");
    }
}
}
