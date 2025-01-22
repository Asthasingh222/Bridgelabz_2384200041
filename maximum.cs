using System;

class Program
{
    /// Calculates the maximum number of handshakes among N students using the formula: n * (n - 1) / 2.
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Formula to calculate the maximum number of handshakes
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + maxHandshakes);
    }
}
