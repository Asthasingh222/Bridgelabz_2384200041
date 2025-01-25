using System;

class LargestDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10, index = 0;
        int[] digits = new int[maxDigit];

        // Extract digits
        while (number > 0)
        {
            if (index == maxDigit)
            {
                break;
            }

            digits[index++] = number % 10;
            number /= 10;
        }

        // Find largest and second largest
        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
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
}
