using System;

class MatrixOperations
{
    // Method to create a random 3x3 matrix
    public static int[,] CreateRandomMatrix()
    {
        Random rand = new Random();
        int[,] matrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = rand.Next(1, 10); // Random numbers between 1 and 9
            }
        }
        return matrix;
    }

    // Method to add two matrices
    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    // Method to subtract two matrices
    public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    // Method to multiply two matrices
    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    // Method to find the transpose of a matrix
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }

    // Method to find the determinant of a 2x2 matrix
    public static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Method to find the determinant of a 3x3 matrix
    public static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    // Method to find the inverse of a 2x2 matrix
    public static double[,] Inverse2x2(int[,] matrix)
    {
        int det = Determinant2x2(matrix);
        double[,] result = new double[2, 2];
        result[0, 0] = matrix[1, 1] / (double)det;
        result[0, 1] = -matrix[0, 1] / (double)det;
        result[1, 0] = -matrix[1, 0] / (double)det;
        result[1, 1] = matrix[0, 0] / (double)det;

        return result;
    }

    // Method to find the inverse of a 3x3 matrix
    public static double[,] Inverse3x3(int[,] matrix)
    {
        int det = Determinant3x3(matrix);
        double[,] result = new double[3, 3];

        result[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / (double)det;
        result[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / (double)det;
        result[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / (double)det;

        result[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / (double)det;
        result[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / (double)det;
        result[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / (double)det;

        result[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / (double)det;
        result[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / (double)det;
        result[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / (double)det;

        return result;
    }

    // Method to display a matrix
    public static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Method to display a matrix (for double values)
    public static void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(Math.Round(matrix[i, j], 2) + "\t");
            }
            Console.WriteLine(); 
        }
    }

    static void Main()
    {
        // Creating two random 3x3 matrices
        int[,] matrix1 = CreateRandomMatrix();
        int[,] matrix2 = CreateRandomMatrix();

        // Display the matrices
        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        // Perform matrix operations
        Console.WriteLine("\nMatrix 1 + Matrix 2:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        Console.WriteLine("\nMatrix 1 - Matrix 2:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        Console.WriteLine("\nMatrix 1 * Matrix 2:");
        DisplayMatrix(MultiplyMatrices(matrix1, matrix2));

        Console.WriteLine("\nTranspose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(matrix1));

        // Determinants and Inverses for 3x3 matrices
        Console.WriteLine("\nDeterminant of Matrix 1: " + Determinant3x3(matrix1));
        Console.WriteLine("\nInverse of Matrix 1:");
        DisplayMatrix(Inverse3x3(matrix1));
    }
}
