using System;

public class Book
{
    public string ISBN;     // Public
    protected string title; // Protected
    private string author;  // Private

    // Constructor
    public Book(string bookISBN, string bookTitle, string bookAuthor)
    {
        ISBN = bookISBN;
        title = bookTitle;
        author = bookAuthor;
    }

    // Public methods to access private author
    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

// Subclass accessing protected and public members
public class EBook : Book
{
    public EBook(string bookISBN, string bookTitle, string bookAuthor) : base(bookISBN, bookTitle, bookAuthor) { }

    public void DisplayDetails()
    {
        Console.WriteLine("E-Book ISBN: " + ISBN + ", Title: " + title);
    }
}

public class Program
{
    public static void Main()
    {
        EBook ebook = new EBook("123456789", "C# for Beginners", "William");
        ebook.DisplayDetails();
        Console.WriteLine("Author: " + ebook.GetAuthor());
    }
}
