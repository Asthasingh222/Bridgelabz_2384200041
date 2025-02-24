using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    // Method to map dictionary values to an object's fields dynamically
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        T obj = new T(); // Create an instance of the class

        foreach (var property in properties)
        {
            // Get the field by name (only public instance fields)
            FieldInfo field = clazz.GetField(property.Key, BindingFlags.Public | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(obj, property.Value); // Set the field value dynamically
            }
        }
        return obj;
    }
}

// Sample class with public fields
class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        // Dictionary containing field names and their values
        var properties = new Dictionary<string, object>
        {
            { "Name", "Amaya Mathur" },
            { "Age", 30 }
        };

        // Convert dictionary data to a Person object
        Person person = ObjectMapper.ToObject<Person>(typeof(Person), properties);

        Console.WriteLine("Name: " + person.Name + ", Age: " + person.Age);
    }
}
