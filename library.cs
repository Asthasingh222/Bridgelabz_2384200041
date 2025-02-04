using System;

class LibraryBook
{
    public string Title, Author;
    public double Price;
    public bool IsAvailable;

    public LibraryBook(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine("Book '{0}' borrowed successfully.",Title);
        }
        else
        {
            Console.WriteLine("Book '{0}' is already borrowed.",Title);
        }
    }

    static void Main()
    {
        LibraryBook book = new LibraryBook("C# Basics", "Sharon", 40);
        book.BorrowBook();
        book.BorrowBook();
    }
}
