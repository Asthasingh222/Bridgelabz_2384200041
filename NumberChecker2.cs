using System;

class NumberChecker2
{
//function to count number of digits in a number
static int CountDigits(int n){
    int count = 0;
    // Loop until the number is reduced to 0
    while (n != 0)
    {
        // Remove the last digit from the number
        n /= 10;
        // Increment the count for each digit
        count++;
    }
    return count;
}

//function to store digits of a number in array
static int[] Digits(int n,int cnt){
    int[] digits =new int[cnt];
    int i=0;
    while (n != 0)
    {
        int digit =n%10;
        digits[i++]=digit;
        n /= 10;
    }
    return digits;
}

//function to find the sum of the digits of the number
static int Sum(int[] arr){
    int sum=0;
    for(int i=0;i<arr.Length;i++)   sum+=arr[i];
    return sum;
}

//function to find the sum of the squares of the digits of a number
static double SumOfSquares(int[] arr){
    double sum=0;
    for(int i=0;i<arr.Length;i++)   sum+=Math.Pow(arr[i],2);
    return sum;
}

//function to check if the number is a harshad number
static bool IsHarshad(int sum,int num){
    return num%sum==0;
}

 // Function to find the frequency of each digit in the number
    static int[,] DigitFrequency(int[] arr)
    {
        int[,] frequency = new int[10, 2]; // Array to store digit (0-9) and their frequencies

        // Initialize the first column with digits 0 to 9
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        // Count the frequency of each digit
        foreach (int digit in arr)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }


    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Display the results
        Console.WriteLine("The number of digits : {0}", CountDigits(number));
        Console.WriteLine("Digits of the number: ");
        int[] arr =Digits(number,CountDigits(number));
        for(int i=0;i<arr.Length;i++)   Console.Write(arr[i]+"  ");
        Console.WriteLine("\nThe sum of the digits : {0}", Sum(arr));
        Console.WriteLine("The sum of the squares of the digits of the number: {0}", SumOfSquares(arr));
        Console.WriteLine("The number is a Harshad number : {0}", IsHarshad(Sum(arr),number));

        // Display the digit frequencies
        Console.WriteLine("Frequency of each digit:");
        int[,] frequency = DigitFrequency(arr);
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine("Digit: {0}, Frequency: {1}", frequency[i, 0], frequency[i, 1]);
            }
        }
    }
}
