using System;

class MeanHeight
{
    static void Main()
    {
        double[] heights = new double[11];
        double sum = 0.0;

        //take input of heights of 11 players from user
        Console.WriteLine("Enter the heights of 11 football players:");
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }

        //formula to calculate mean of heights
        double mean = sum / heights.Length;
        Console.WriteLine("The mean height of the football team is: {0}",mean);
    }
}
