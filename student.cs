using System;

class StudentScorecard
{
    // Generate random scores for students
    public static int[,] GenerateScores(int students)
    {
        Random random = new Random();
        int[,] scores = new int[students, 3]; // Physics, Chemistry, Math

        for (int i = 0; i < students; i++)
        {
            scores[i, 0] = random.Next(0, 101); // Physics
            scores[i, 1] = random.Next(0, 101); // Chemistry
            scores[i, 2] = random.Next(0, 101); // Math
        }

        return scores;
    }

    // Calculate total, average, and percentage
    public static double[,] CalculateResults(int[,] scores)
    {
        int students = scores.GetLength(0);
        double[,] results = new double[students, 3]; // Columns for total, average, and percentage

        for (int i = 0; i < students; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = total / 300.0 * 100;

            results[i, 0] = total; // Storing total in column 0
            results[i, 1] = Math.Round(average, 2); // Storing average in column 1
            results[i, 2] = Math.Round(percentage, 2); // Storing percentage in column 2
        }

        return results;
    }

    static void Main()
    {
        Console.WriteLine("Enter the number of students:");
        int students = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(students);
        double[,] results = CalculateResults(scores);

        Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");
        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}", i + 1, scores[i, 0], scores[i, 1], scores[i, 2], results[i, 0], results[i, 1], results[i, 2]);

        }
    }
}
