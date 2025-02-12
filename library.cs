using System;

// Class representing a node in the doubly linked list
class BookNode {
    public string title;
    public string author;
    public string genre;
    public int bookID;
    public bool isAvailable;
    public BookNode next;
    public BookNode prev;

    public BookNode(string title, string author, string genre, int bookID, bool isAvailable) {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.bookID = bookID;
        this.isAvailable = isAvailable;
        this.next = null;
        this.prev = null;
    }
}

// Class representing the Library Management System
class Library {
    private BookNode head;

    // Add a book at the beginning of the list
    public void AddAtBeginning(string title, string author, string genre, int bookID, bool isAvailable) {
        BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
        if (head != null) {
            head.prev = newNode;
        }
        newNode.next = head;
        head = newNode;
    }

    // Add a book at the end of the list
    public void AddAtEnd(string title, string author, string genre, int bookID, bool isAvailable) {
        BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
        if (head == null) {
            head = newNode;
            return;
        }
        BookNode temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.prev = temp;
    }

    // Add a book at a specific position
    public void AddAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position) {
        if (position < 0) {
            Console.WriteLine("Invalid position.");
            return;
        }
        BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
        if (position == 0) {
            AddAtBeginning(title, author, genre, bookID, isAvailable);
            return;
        }
        BookNode temp = head;
        for (int i = 0; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Position out of range.");
            return;
        }
        newNode.next = temp.next;
        newNode.prev = temp;
        if (temp.next != null) {
            temp.next.prev = newNode;
        }
        temp.next = newNode;
    }

    // Remove a book by Book ID
    public void RemoveBook(int bookID) {
        if (head == null) {
            Console.WriteLine("Library is empty.");
            return;
        }
        BookNode temp = head;
        while (temp != null && temp.bookID != bookID) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Book not found.");
            return;
        }
        if (temp.prev != null) {
            temp.prev.next = temp.next;
        } else {
            head = temp.next;
        }
        if (temp.next != null) {
            temp.next.prev = temp.prev;
        }
        Console.WriteLine("Book with ID {0} removed successfully.", bookID);
    }

    // Search for a book by title or author
    public void SearchBook(string keyword) {
        BookNode temp = head;
        while (temp != null) {
            if (temp.title.Contains(keyword) || temp.author.Contains(keyword)) {
                Console.WriteLine("Found: {0} by {1} | Genre: {2} | ID: {3} | Available: {4}", temp.title, temp.author, temp.genre, temp.bookID, temp.isAvailable);
            }
            temp = temp.next;
        }
    }

    // Update the availability status of a book
    public void UpdateAvailability(int bookID, bool isAvailable) {
        BookNode temp = head;
        while (temp != null && temp.bookID != bookID) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Book not found.");
            return;
        }
        temp.isAvailable = isAvailable;
        Console.WriteLine("Availability updated for book ID {0}.", bookID);
    }

    // Display all books in forward order
    public void DisplayBooksForward() {
        BookNode temp = head;
        while (temp != null) {
            Console.WriteLine("Title: {0}, Author: {1}, Genre: {2}, ID: {3}, Available: {4}", temp.title, temp.author, temp.genre, temp.bookID, temp.isAvailable);
            temp = temp.next;
        }
    }

    // Display all books in reverse order
    public void DisplayBooksBackward() {
        if (head == null) {
            Console.WriteLine("Library is empty.");
            return;
        }
        BookNode temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        while (temp != null) {
            Console.WriteLine("Title: {0}, Author: {1}, Genre: {2}, ID: {3}, Available: {4}", temp.title, temp.author, temp.genre, temp.bookID, temp.isAvailable);
            temp = temp.prev;
        }
    }

    // Count the total number of books
    public int CountBooks() {
        int count = 0;
        BookNode temp = head;
        while (temp != null) {
            count++;
            temp = temp.next;
        }
        return count;
    }
}

class Program {
    public static void Main(string[] args) {
        Library library = new Library();
        library.AddAtBeginning("The Alchemist", "Paulo Coelho", "Fiction", 101, true);
        library.AddAtEnd("1984", "George Orwell", "Dystopian", 102, false);
        library.AddAtPosition("Harry Potter", "J.K. Rowling", "Fantasy", 103, true, 1);

        Console.WriteLine("Library Books:");
        library.DisplayBooksForward();
        
        Console.WriteLine("\nTotal Books: {0}", library.CountBooks());
        
        Console.WriteLine("\nRemoving Book with ID 102");
        library.RemoveBook(102);
        library.DisplayBooksForward();
        
        Console.WriteLine("\nSearching for 'Harry'");
        library.SearchBook("Harry");
        
        Console.WriteLine("\nUpdating Availability of Book ID 103");
        library.UpdateAvailability(103, false);
        library.DisplayBooksForward();
        
        Console.WriteLine("\nDisplaying in Reverse Order:");
        library.DisplayBooksBackward();
    }
}
