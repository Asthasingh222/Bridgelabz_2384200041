using System;

class Person
{
    public string Name;
    public int Age;

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Person(Person p)
    {
        Name = p.Name;
        Age = p.Age;
    }

    public void DisplayPerson()
    {
        Console.WriteLine("Name: {0}, Age: {1}",Name,Age);
    }

    static void Main()
    {
        Person p1 = new Person("Astha", 22);
        Person p2 = new Person(p1); // Cloning p1

        p1.DisplayPerson();
        p2.DisplayPerson();
    }
}
