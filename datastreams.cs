using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.dat"; // Binary file to store student data

        // Writing student data to a binary file
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(101); // Writing Roll Number
                writer.Write("Alice"); // Writing Name
                writer.Write(3.9f); // Writing GPA (float)
            }

            Console.WriteLine("Student data written successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }

        // Reading student data from the binary file
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int rollNo = reader.ReadInt32(); // Reading Roll Number
                string name = reader.ReadString(); // Reading Name
                float gpa = reader.ReadSingle(); // Reading GPA

                Console.WriteLine("Read Student Data:");
                Console.WriteLine("Roll No: " + rollNo + ", Name: " + name + ", GPA: " + gpa);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}
