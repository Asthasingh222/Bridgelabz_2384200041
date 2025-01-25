using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter the elements of the matrix:");

        // Input elements of the 2D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Element [{0},{1}]: ",i,j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to store elements of the 2D array
        int[] array = new int[rows * cols];
        int index = 0;

        // Copy elements from 2D array to 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[index++] = matrix[i,j];
            }
        }

        // Display the 1D array
        Console.WriteLine("1D Array:");
        Console.WriteLine(string.Join(", ", array));
    }
}
