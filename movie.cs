using System;

class MovieNode {
    public string title;
    public string director;
    public int yearOfRelease;
    public double rating;
    public MovieNode next;
    public MovieNode prev;
    public MovieNode(string name, string director, int yor, double rating) {
        this.title = name;
        this.director = director;
        this.yearOfRelease = yor;
        this.rating = rating;
        this.next = null;
        this.prev = null;
    }
}

class MovieList {
    private MovieNode head;

    // Add an item at the beginning
    public void AddAtBeginning(string name, string director, int yor, double rating) {
        MovieNode newNode = new MovieNode(name, director, yor, rating);
        newNode.next = head;
        if (head != null) {
        head.prev = newNode;
        }
        head = newNode;
    }

    // Add an item at the end
    public void AddAtEnd(string name, string director, int yor, double rating) {
        MovieNode newNode = new MovieNode(name, director, yor, rating);
        if (head == null) {
            head = newNode;
            return;
        }
        MovieNode temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.prev = temp;
    }

    // Add an item at a specific position
    public void AddAtPosition(string name, string director, int yor, double rating,int position) {
        if (position < 0) {
            Console.WriteLine("Invalid position.");
            return;
        }
        MovieNode newNode = new MovieNode(name, director, yor, rating);
        if (position == 0) {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            return;
        }
        MovieNode temp = head;
        while (temp != null && position > 1) {
            temp = temp.next;
            position--;
        }
        if (temp == null) {
            Console.WriteLine("Position out of range.");
            return;
        }
        newNode.next = temp.next;
        newNode.prev = temp;
        temp.next.prev =newNode;
        temp.next =newNode;
    }

    // Remove an item by Movie title
    public void RemoveRecord(string  title) {
        if (head == null) {
            Console.WriteLine("Movie list is empty.");
            return;
        }
        if (head.title == title) {
            head = head.next;
            head.prev.next = null;
            head.prev = null;
            Console.WriteLine("Movie with title {0} is  removed successfully.",title);
            return;
        }
        MovieNode temp = head;
        while (temp.next != null && temp.next.title != title) {
            temp = temp.next;
        }
        if (temp.next == null) {
            Console.WriteLine("Item not found.");
            return;
        }
        temp.next = temp.next.next;
        temp.next.prev =temp;
        Console.WriteLine("Movie with title {0} is  removed successfully.",title);
    }

    // Update the rating  of a Movie by Movie title
    public void UpdateRating(string title, double rating) {
        MovieNode temp = head;
        while (temp != null && temp.title != title) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Item not found.");
            return;
        }
        temp.rating = rating;
        Console.WriteLine("Rating of movie is updated successfully.");
    }

    // Search for a movie record by director
    public void SearchByDirector(string director) {
        MovieNode temp = head;
        while (temp != null && temp.director != director) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Item not found.");
            return;
        }
        Console.WriteLine("Item Found: {0}, Director: {1}, year of Release: {2}, Rating: {3}", temp.title, temp.director, temp.yearOfRelease, temp.rating);
    }

    // Display all movies in forward
    public void DisplayMoviesForward() {
        MovieNode temp = head;
        while (temp != null) {
            Console.WriteLine("Movie Title: {0}, Director: {1}, year of Release: {2}, Rating: {3}", temp.title, temp.director, temp.yearOfRelease, temp.rating);
            temp = temp.next;
        }
    }
    //display all movies in backward
    public void DisplayMoviesBackward() {
        MovieNode temp = head;
        while (temp.next!= null) {
            temp = temp.next;
        }
         while (temp!= null) {
            Console.WriteLine("Movie Title: {0}, Director: {1}, year of Release: {2}, Rating: {3}", temp.title, temp.director, temp.yearOfRelease, temp.rating);
            temp = temp.prev;
        }
    }
}

class Program {
    public static void Main(string[] args) {
        MovieList Movie = new MovieList();
        
        Movie.AddAtBeginning("Lagaan","Ashutosh Gowariket",2001,8.1);
        Movie.AddAtEnd("3 Idiots", "Rajkumar Hirani",2009,8.4);
        Movie.AddAtBeginning("Baahubali", "S. Rajamouli", 2015, 8.0);
        Movie.AddAtEnd("Ashram", "Sriram Raghav", 2018, 7.0);
        Movie.AddAtPosition("Drishyam", "Nishikant kamat", 2015, 7.5,2);
        
        Console.WriteLine("--- Movie List ---");
        Movie.DisplayMoviesForward();
        
        Console.WriteLine("\nUpdating Movie's Rating of Ashram to 7.4");
        Movie.UpdateRating("Ashram", 7.4);
        Movie.DisplayMoviesForward();
        
        Console.WriteLine("\nSearching for Director Ashutosh Gowariket");
        Movie.SearchByDirector("Ashutosh Gowariket");
        
        Console.WriteLine("\nRemoving Movie: Drishyam ");
        Movie.RemoveRecord("Drishyam");
        Movie.DisplayMoviesForward();

        Console.WriteLine("\n-----Movie List in backward----- ");
        Movie.DisplayMoviesBackward();
    }
}
