using System;

class NumberChecker
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

//function to check if the number is a duck number(non-zero digits present)
static bool IsDuck(int[] arr){
    bool flag=true;
    for(int i=0;i<arr.Length;i++){
        if(arr[i]==0)   flag=false;
    }
    return flag;
}

//function to check if the number is a armstrong number
static bool IsArmstrong(int[] arr,int n,int cnt){
    double sum=0;
    for(int i=0;i<cnt;i++){
        sum+=Math.Pow(arr[i],cnt);
    }
    if(sum ==n) return true;
    return false;
}

//function to find largest and the second largest number from digits of the number
static void LargestAndSecondLargest(int[] digits){
    // Find largest and second largest
        int largest = Int32.MinValue, secondLargest = Int32.MinValue;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest: {0}",largest);
        Console.WriteLine("Second Largest: {0}",secondLargest);
}

//function to find smallest and the second smallest number from digits of the number
static void SmallestAndSecondSmallest(int[] digits){
    // Find largest and second largest
        int smallest =Int32.MaxValue , secondsmallest = Int32.MaxValue;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                secondsmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondsmallest && digits[i] != smallest)
            {
                secondsmallest = digits[i];
            }
        }

        Console.WriteLine("Smallest: {0}",smallest);
        Console.WriteLine("Second Smallest: {0}",secondsmallest);
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
        Console.WriteLine("\nThe number is a duck number : {0}", IsDuck(arr));
        Console.WriteLine("The number is a Armstrong number : {0}", IsArmstrong(arr,number,CountDigits(number)));
        LargestAndSecondLargest(arr);
        SmallestAndSecondSmallest(arr);
    }
}
