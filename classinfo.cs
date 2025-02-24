using System;
using System.Reflection;

class SampleClass
{
    public int PublicField;  // Public field
    private string PrivateField; // Private field

    public SampleClass() { }  // Default constructor
    public SampleClass(int x) { }  // Parameterized constructor

    public void PublicMethod() { }  // Public method
    private void PrivateMethod() { }  // Private method
}

class Program
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();  // Read class name from user

        Type type = Type.GetType(className); // Get Type object dynamically

        if (type != null)
        {
            Console.WriteLine("\nClass: {0}",type.Name);

            // Display all methods (both public and private)
            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance|BindingFlags.DeclaredOnly))
                Console.WriteLine(method.Name);

            // Display all fields (both public and private)
            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance|BindingFlags.DeclaredOnly))
                Console.WriteLine(field.Name);

            // Display all constructors
            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo constructor in type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance|BindingFlags.DeclaredOnly))
                Console.WriteLine(constructor.ToString());
        }
        else
        {
            Console.WriteLine("Class not found.");
        }
    }
}
