using System;

class Program
{
    //  fint the smallest and the largest among three numbers and return it in array
    public static int[] FindSmallestAndLargest(int n1,int n2,int n3){
        int s=Math.Min(n1,Math.Min(n2,n3));
        int l=Math.Max(n1,Math.Max(n2,n3));
        return new int[] {s,l};
    }
    static void Main()
    {
        // Prompt user for three number
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int smallest =FindSmallestAndLargest(a,b,c)[0];
        int largest =FindSmallestAndLargest(a,b,c)[1];
        
        Console.WriteLine("Smallest of three numbers: "+smallest);
        Console.WriteLine("largest of three numbers: "+largest);
    }
}
