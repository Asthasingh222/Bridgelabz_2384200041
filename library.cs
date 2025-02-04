using System;

class Book
{
    private static string libraryName = "Siksha Library";
    private string title;
    private string author;
    private readonly decimal isbn;

    // Getter methods
    public static string GetLibraryName()
    {
        return libraryName;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public decimal GetISBN()
    {
        return isbn;
    }

    // Constructor
    public Book(string title, string author, decimal isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + GetLibraryName());
    }

    // Method to display book details
    public void DisplayDetails()
    {
        DisplayLibraryName();
        Console.WriteLine("Book Title: " + GetTitle() + ", Author: " + GetAuthor() + ", ISBN: " + GetISBN());
    }

    static void Main()
    {
        Book book1 = new Book("C# Fundamentals", "Sharon", 3489742);
        if (book1 is Book) book1.DisplayDetails();

        Book book2 = new Book("Java Programming", "Shreya", 453210);
        if (book2 is Book) book2.DisplayDetails();
    }
}
