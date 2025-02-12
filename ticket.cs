using System;

class TicketNode
{
    public int ticketId;
    public string customerName;
    public string movieName;
    public string seatNumber;
    public DateTime bookingTime;
    public TicketNode next;

    public TicketNode(int ticketId, string customerName, string movieName, string seatNumber)
    {
        this.ticketId = ticketId;
        this.customerName = customerName;
        this.movieName = movieName;
        this.seatNumber = seatNumber;
        this.bookingTime = DateTime.Now;
        this.next = null;
    }
}

class TicketReservationSystem
{
    private TicketNode head = null;
    private int ticketCount = 0;

    // Add a new ticket at the end of the circular list
    public void AddTicket(int ticketId, string customerName, string movieName, string seatNumber)
    {
        TicketNode newTicket = new TicketNode(ticketId, customerName, movieName, seatNumber);
        ticketCount++;

        if (head == null)
        {
            head = newTicket;
            head.next = head; // Circular link
        }
        else
        {
            TicketNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newTicket;
            newTicket.next = head;
        }

        Console.WriteLine("Ticket booked successfully! Ticket ID: " + ticketId + ", Customer: " + customerName + ", Movie: " + movieName + ", Seat: " + seatNumber);
    }

    // Remove a ticket by Ticket ID
    public void RemoveTicket(int ticketId)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode temp = head, prev = null;

        // If head is the ticket to remove
        if (head.ticketId == ticketId)
        {
            if (head.next == head)
            {
                head = null;
                ticketCount--;
                Console.WriteLine("Ticket removed: " + ticketId + ". No tickets left.");
                return;
            }

            while (temp.next != head)
                temp = temp.next;

            head = head.next;
            temp.next = head;
            ticketCount--;
            Console.WriteLine("Ticket removed: " + ticketId);
            return;
        }

        // Search for the ticket
        do
        {
            prev = temp;
            temp = temp.next;

            if (temp.ticketId == ticketId)
            {
                prev.next = temp.next;
                ticketCount--;
                Console.WriteLine("Ticket removed: " + ticketId);
                return;
            }
        } while (temp != head);

        Console.WriteLine("Ticket not found: " + ticketId);
    }

    // Display all tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Console.WriteLine("Current Ticket Reservations:");
        TicketNode temp = head;

        do
        {
            Console.WriteLine("Ticket ID: " + temp.ticketId + ", Customer: " + temp.customerName + ", Movie: " + temp.movieName + ", Seat: " + temp.seatNumber + ", Booking Time: " + temp.bookingTime);
            temp = temp.next;
        } while (temp != head);
    }

    // Search for a ticket by Customer Name or Movie Name
    public void SearchTicket(string searchKey)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        TicketNode temp = head;
        bool found = false;

        do
        {
            if (temp.customerName.Equals(searchKey, StringComparison.OrdinalIgnoreCase) || temp.movieName.Equals(searchKey, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ticket Found - Ticket ID: " + temp.ticketId + ", Customer: " + temp.customerName + ", Movie: " + temp.movieName + ", Seat: " + temp.seatNumber);
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No ticket found for: " + searchKey);
    }

    // Get total number of booked tickets
    public void GetTotalTickets()
    {
        Console.WriteLine("Total booked tickets: " + ticketCount);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        TicketReservationSystem ticketSystem = new TicketReservationSystem();

        // Adding tickets
        ticketSystem.AddTicket(101, "Arti", "Avengers", "A1");
        ticketSystem.AddTicket(102, "Monika", "Inception", "B2");
        ticketSystem.AddTicket(103, "Kanika", "Avatar", "C3");

        // Display tickets
        ticketSystem.DisplayTickets();

        // Search for a ticket
        ticketSystem.SearchTicket("Inception");
        ticketSystem.SearchTicket("David");

        // Get total tickets
        ticketSystem.GetTotalTickets();

        // Remove a ticket
        ticketSystem.RemoveTicket(102);
        ticketSystem.DisplayTickets();

        // Get total tickets after removal
        ticketSystem.GetTotalTickets();
    }
}
