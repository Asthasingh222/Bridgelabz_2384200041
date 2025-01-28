using System;

class MeanHeight
{
    static int Sum(int[] arr){
        int sum=0;
        for(int i=0;i<arr.Length;i++)   sum+=arr[i];
        return sum;
    }
    static int Mean(int len,int sum){
        return sum/len;
    }
    static int Shortest(int[] arr){
        int mini=arr[0];
        for(int i=0;i<arr.Length;i++)   mini=Math.Min(mini,arr[i]);
        return mini;
    }
    static int Tallest(int[] arr){
        int maxi=arr[0];
        for(int i=0;i<arr.Length;i++)   maxi=Math.Max(maxi,arr[i]);
        return maxi;
    }
    static void Main()
    {
        int[] heights = new int[11];
        Random random = new Random();


        for (int i = 0; i < 11; i++)
        {
            // Generate a random 3-digit height in cm
            heights[i] = random.Next(100, 1000);
        }
        
        //Display the result
        Console.WriteLine("Generated random heights:");
        for (int i = 0; i < 11; i++)
        {
            Console.Write(heights[i]+"  ");
        }
        Console.WriteLine("\nSum of all heights:"+Sum(heights));
        Console.WriteLine("Mean of all heights:"+Mean(heights.Length,Sum(heights)));
        Console.WriteLine("Tallest of all heights:"+Tallest(heights));
        Console.WriteLine("Shortest of all heights:"+Shortest(heights));
    }
}
