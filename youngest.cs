using System;

class FriendsComparison
{
     // Finds the index of the tallest friend.
    static int FindTallest(double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }
        return tallestIndex;
    }
        //Finds the index of the youngest friend.
    static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
        }
        return youngestIndex;
    }
    static void Main()
    {
        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Input ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of {0}: ",names[i]);
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of {0} in cm: ",names[i]);
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find and display the youngest and tallest
        Console.WriteLine("The youngest is {0}",names[FindYoungest(ages)]);
        Console.WriteLine("The tallest is {0}",names[FindTallest(heights)]);
    }



   
}
