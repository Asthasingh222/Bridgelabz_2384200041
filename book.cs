using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine("Title: {0}, Author: {1}, Price: {2}",Title,Author,Price);
    }

    static void Main()
    {
        Book book1 = new Book();
        Book book2 = new Book("C# Programming", "Astha Singh", 250);

        book1.DisplayBookDetails();
        book2.DisplayBookDetails();
    }
}
