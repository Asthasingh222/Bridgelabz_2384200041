using System;
using System.Collections.Generic;

// Abstract class representing a Library Item
abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;

    // Constructor to initialize library item
    public LibraryItem(string id, string title, string author)
    {
        this.itemId = id;
        this.title = title;
        this.author = author;
    }

    // Encapsulation: Providing only getters for private fields
    public string GetItemId() { return itemId; }
    public string GetTitle() { return title; }
    public string GetAuthor() { return author; }

    // Method to display item details
    public void GetItemDetails()
    {
        Console.WriteLine("ID: " + itemId + ", Title: " + title + ", Author: " + author);
    }

    // Abstract method to be implemented by subclasses
    public abstract int GetLoanDuration(); 
}

// Interface for reservable items
interface IReservable
{
    void ReserveItem(); // Method to reserve an item
    bool CheckAvailability(); // Method to check if item is available
}

// Book class implementing reservable interface
class Book : LibraryItem, IReservable
{
    private bool isReserved;

    public Book(string id, string title, string author) : base(id, title, author)
    {
        isReserved = false;
    }

    // Loan duration specific to books
    public override int GetLoanDuration()
    {
        return 14; // 14 days for books
    }

    // Reserving a book
    public void ReserveItem()
    {
        isReserved = true;
        Console.WriteLine(GetTitle() + " has been reserved.");
    }

    // Checking availability
    public bool CheckAvailability()
    {
        return !isReserved;
    }
}

// Magazine class (non-reservable)
class Magazine : LibraryItem
{
    public Magazine(string id, string title, string author) : base(id, title, author) { }

    // Loan duration specific to magazines
    public override int GetLoanDuration()
    {
        return 7; // 7 days for magazines
    }
}

// DVD class implementing reservable interface
class DVD : LibraryItem, IReservable
{
    private bool isReserved;

    public DVD(string id, string title, string author) : base(id, title, author)
    {
        isReserved = false;
    }

    // Loan duration specific to DVDs
    public override int GetLoanDuration()
    {
        return 5; // 5 days for DVDs
    }

    // Reserving a DVD
    public void ReserveItem()
    {
        isReserved = true;
        Console.WriteLine(GetTitle() + " has been reserved.");
    }

    // Checking availability
    public bool CheckAvailability()
    {
        return !isReserved;
    }
}

// Main class to test the library management system
class Program
{
    static void Main()
    {
        // Creating a list of library items
        List<LibraryItem> libraryItems = new List<LibraryItem>();
        libraryItems.Add(new Book("B101", "The Great Gatsby", "F. Scott Fitzgerald"));
        libraryItems.Add(new Magazine("M202", "Time Magazine", "Various"));
        libraryItems.Add(new DVD("D303", "Inception", "Christopher Nolan"));

        // Iterating through each item and displaying details
        foreach (LibraryItem item in libraryItems)
        {
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

            // Checking if the item is reservable
            if (item is IReservable)
            {
                IReservable reservableItem = (IReservable)item;
                Console.WriteLine("Available: " + reservableItem.CheckAvailability());
                reservableItem.ReserveItem();
                Console.WriteLine("Available after reservation: " + reservableItem.CheckAvailability());
            }
            Console.WriteLine("-------------------------");
        }
    }
}