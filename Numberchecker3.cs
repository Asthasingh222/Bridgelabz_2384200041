using System;

class NumberChecker3
{
    // Method to count number of digits in a number
    static int CountDigits(int n)
    {
        int count = 0;
        while (n != 0)
        {
            n /= 10;
            count++;
        }
        return count;
    }

    // Method to store digits of a number in an array
    static int[] Digits(int n, int cnt)
    {
        int[] digits = new int[cnt];
        int i = 0;
        while (n != 0)
        {
            digits[cnt-i-1] = n % 10;
            i++;
            n /= 10;

        }
        return digits;
    }

    // Method to reverse the digits array
    static int[] ReverseArray(int[] arr)
    {
        int[] reversed = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversed[i] = arr[arr.Length - 1 - i];
        }
        return reversed;
    }

    // Method to compare two arrays and check if they are equal
    static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

    // Method to check if a number is a palindrome using its digits
    static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    // Method to check if a number is a duck number
    static bool IsDuckNumber(int[] digits)
    {
        bool flag=true;
        for(int i=0;i<digits.Length;i++){
        if(digits[i]==0)   flag=false;
    }
    return flag;
    }

    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Process and display results
        int digitCount = CountDigits(number);
        Console.WriteLine("The number of digits: {0}", digitCount);

        int[] digits = Digits(number, digitCount);
        Console.WriteLine("Digits of the number:");
        for(int i=0;i<digits.Length;i++)    Console.Write(digits[i] + " ");

        int[] reversedDigits = ReverseArray(digits);
        Console.WriteLine("\nReversed digits of the number:");
        foreach (int digit in reversedDigits) Console.Write(digit + " ");

        Console.WriteLine("\nIf array and revered array are equal: "+ AreArraysEqual(digits,reversedDigits));
        Console.WriteLine("\nThe number is a palindrome: {0}", IsPalindrome(digits));
        Console.WriteLine("The number is a duck number: {0}", IsDuckNumber(digits));
    }
}
