using System;
using System.Text;
using System.Reflection;

class JsonConverter
{
    // Method to convert an object's fields into a JSON-like string
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder json = new StringBuilder();
        json.Append("{ ");

        // Get all public instance fields
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
        for (int i = 0; i < fields.Length; i++)
        {
            json.Append("\"" + fields[i].Name + "\": \"" + fields[i].GetValue(obj) + "\"");

            if (i < fields.Length - 1)
            {
                json.Append(", ");
            }
        }
        json.Append(" }");
        return json.ToString();
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
        // Create an instance of Person
        Person person = new Person { Name = "John Doe", Age = 30 };

        // Convert object to JSON-like string
        string jsonString = JsonConverter.ToJson(person);

        Console.WriteLine(jsonString);
    }
}
