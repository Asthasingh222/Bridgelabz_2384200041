using System;

// Base class: Book
public class Book
{
    public string Title { get; private set; }
    public int PublicationYear { get; private set; }

    public Book(string title, int year)
    {
        Title = title;
        PublicationYear = year;
    }

    // Virtual method to allow overriding in the subclass
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book: {0}, Published in {1}",Title,PublicationYear);
    }
}

// Subclass: Author (inherits from Book)
public class Author : Book
{
    public string Name { get; private set; }
    public string Bio { get; private set; }

    public Author(string title, int year, string name, string bio)
        : base(title, year)
    {
        Name = name;
        Bio = bio;
    }

    // Overriding DisplayInfo method to add author details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author: {0}, Bio: {1}",Name,Bio);
    }
}

class Program
{
    static void Main()
    {
        Author author = new Author("C# Programming", 2021, "Akash Maheshwari", "Expert in C#");
        author.DisplayInfo();
    }
}
