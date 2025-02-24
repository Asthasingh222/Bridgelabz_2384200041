using System;
using System.Reflection;

class Person
{
    private int age = 25; // Private field
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        // Get private field 'age'
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (field != null)
        {
            // Get and print the original value
            Console.WriteLine("Original Age: " + field.GetValue(person));

            // Modify the value
            field.SetValue(person, 30);

            // Get and print the modified value
            Console.WriteLine("Modified Age: " + field.GetValue(person));
        }
        else
        {
            Console.WriteLine("Field not found.");
        }
    }
}