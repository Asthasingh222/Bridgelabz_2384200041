using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Nested try block to handle multiple exceptions separately
            try
            {
                // Prompt user to enter the size of the array
                Console.Write("Enter size of the array: ");
                int size = Convert.ToInt32(Console.ReadLine());

                // Create an array of given size
                int[] arr = new int[size];

                // Loop to get array elements from the user
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Prompt user to enter an index
                Console.Write("Enter an index: ");
                int index = Convert.ToInt32(Console.ReadLine());

                // Retrieve the element at the specified index
                int temp = arr[index];

                // Prompt user to enter a divisor
                Console.Write("Enter a divisor: ");
                int div = Convert.ToInt32(Console.ReadLine());

                // Perform division and display the result
                Console.WriteLine("Result: " + temp / div);
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero error
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        // Handle IndexOutOfRangeException separately
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
