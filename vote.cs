using System;

class VotingEligibility
{
    static void Main()
    {
        // Define an array to store the ages of 10 students
        int[] studentAges = new int[10];

        Console.WriteLine("Enter the ages of 10 students:");
        for (int i = 0; i < studentAges.Length; i++)
        {
            // Input each student's age
            studentAges[i] = int.Parse(Console.ReadLine());
        }

        // Loop through the array to check eligibility
        foreach (int age in studentAges)
        {
            if (age < 0)
                Console.WriteLine("Invalid age");
            else if (age >= 18)
                Console.WriteLine("The student with the age {0} can vote.",age);
            else
                Console.WriteLine("The student with the age {0} cannot vote.",age);
        }
    }
}
