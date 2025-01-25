using System;

class FriendsComparison
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input age and height for each friend
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of {0}: ",names[i]);
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of {0} (in cm): ",names[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Find youngest and tallest
        int youngestIndex = 0, tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex]) youngestIndex = i;
            if (heights[i] > heights[tallestIndex]) tallestIndex = i;
        }

        Console.WriteLine("The youngest is {0}.",names[youngestIndex]);
        Console.WriteLine("The tallest is {0}.",names[tallestIndex]);
    }
}
