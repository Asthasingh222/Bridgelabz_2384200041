using System;

class Program
{
     // Method to get array input from the user
    static int[] GetArrayFromUser()
    {
        try
        {
            Console.Write("Enter size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                Console.WriteLine("Invalid array size. Returning null.");
                return null; // This will trigger NullReferenceException
            }

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
            return null; // If the user enters an invalid size, return null
        }
    }
    static void Main()
    {
        try
        {
            int[] numbers = GetArrayFromUser(); // Get array from user input

            Console.Write("Enter an index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Check for null explicitly before accessing the array
            if (numbers == null)
            {
                throw new NullReferenceException();
            }

            Console.WriteLine("Value at index {0}: {1}",index,numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }

    }

}
