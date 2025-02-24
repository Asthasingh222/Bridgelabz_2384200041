using System;
using System.Reflection;
using System.Text.Json;

// Define the attribute
[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

// Apply the attribute to a User class
class User
{
    [JsonField("user_name")]
    public string Username = "Rohan";
}

// Convert an object to JSON-like format
class Program
{
    static void Main()
    {
        User user = new User();
        Type type = user.GetType();
        var json = new System.Collections.Generic.Dictionary<string, object>();

        foreach (FieldInfo field in type.GetFields())
        {
            JsonFieldAttribute attr = field.GetCustomAttribute<JsonFieldAttribute>();
            string jsonKey = attr != null ? attr.Name : field.Name;
            json[jsonKey] = field.GetValue(user);
        }

        Console.WriteLine(JsonSerializer.Serialize(json));
    }
}
