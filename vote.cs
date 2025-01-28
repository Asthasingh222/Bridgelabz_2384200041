using System;

class StudentVoteChecker
{
    // Checks if a student is eligible to vote based on age.
    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false; // Invalid age
        return age >= 18; // Voting eligibility
    }
    static void Main()
    {
        // Initialize an array to store ages
        int[] ages = new int[10];

        // Input ages for 10 students
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student {0}: ",i+1);
            ages[i] = int.Parse(Console.ReadLine());
        }

        // Check voting eligibility for each student
        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine("Student with age {0} {1} vote.",ages[i],CanStudentVote(ages[i]) ? "can" : "cannot");
        }
    }

}
