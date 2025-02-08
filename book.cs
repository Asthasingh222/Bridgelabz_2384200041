using System;
using System.Collections.Generic;

// Book class, which can exist independently of a Library
class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    
    // Constructor to initialize book details
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
    
    // Method to display book details
    public void Display()
    {
        Console.WriteLine("Book: " + Title + ", Author: " + Author);
    }
}

// Library class that aggregates multiple Book objects
class Library
{
    public string Name { get; private set; }
    public List<Book> Books { get; private set; } // Aggregation: Library has a collection of Books

    // Constructor to initialize library with a name
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>(); // Initializing the list of books
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        if (book != null)
        {
            Books.Add(book);
        }
    }

    // Method to display library details along with books
    public void DisplayBooks()
    {
        Console.WriteLine("Library: " + Name);
        if (Books.Count > 0)
        {
            foreach (var book in Books)
            {
                book.Display();
            }
        }
        else
        {
            Console.WriteLine("No books available in this library.");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Creating book objects
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("1984", "George Orwell");
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee");

        // Creating library objects
        Library library1 = new Library("City Library");
        Library library2 = new Library("University Library");

        // Adding books to different libraries
        library1.AddBook(book1);
        library1.AddBook(book2);
        
        library2.AddBook(book2); // The same book can exist in multiple libraries
        library2.AddBook(book3);
        
        // Displaying details
        library1.DisplayBooks();
        Console.WriteLine();
        library2.DisplayBooks();
    }
}