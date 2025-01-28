using System;

class Program
{
    //calculate maximum number of handshakes
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
    static void Main(string[] args)
    {
        //prompt to enter number of students
        Console.Write("Enter the number of students: ");
        int students = int.Parse(Console.ReadLine());
        int handshakes = CalculateHandshakes(students);
        Console.WriteLine("The maximum number of handshakes is {0}.",handshakes);
    }

}
