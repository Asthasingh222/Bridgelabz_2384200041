using System;

    // Book class with attributes and methods
    class Book
    {
        // Private attributes
        private string title;
        private string author;
        private double price;

        // Constructor to initialize book details
        public Book(string bookTitle, string bookAuthor, double bookPrice)
        {
            title = bookTitle;
            author = bookAuthor;
            price = bookPrice;
        }

        // Method to display book details
        public void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a Book object
            Book book = new Book("C# Programming", "Astha Singh", 250);

            // Displaying Book details
            book.DisplayDetails();
        }
    }

