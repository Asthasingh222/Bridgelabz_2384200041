using System;

class NumberAnalysis
{
    //function to check if the number is positive or negative
    public static bool IsPositive(int n){
        return n>=0;
    }

    //function to check if the number is even or odd
    public static bool IsEven(int n){
        return n%2==0;
    }
    //function to compare two numbers
    public static int Compare(int a,int b){
        if(a>b) return 1;
        if(a<b) return -1;
        else return 0;
    }
    static void Main()
    {
        int[] numbers = new int[5];

        // Input 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ",i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Analyze each number
        foreach (var number in numbers)
        {
            if (IsPositive(number))
            {
                Console.WriteLine("{0} is Positive",number);
                if(IsEven(number))  Console.WriteLine("{0} is Even",number);
                else    Console.WriteLine("{0} is Odd",number);
            }
            else    Console.WriteLine("{0} is Negative",number);
        }
        Console.WriteLine("Comparing first({0}) and last element({1}) of array",numbers[0],numbers[4]);
        int comp =Compare(numbers[0],numbers[4]);
        if(comp==1) Console.WriteLine("{0} is greater",numbers[0]);
        else if(comp==-1) Console.WriteLine("{0} is greater",numbers[4]);
        else Console.WriteLine("Both are equal");

    }
}