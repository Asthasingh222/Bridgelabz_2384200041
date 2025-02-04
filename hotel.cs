using System;

class HotelBooking
{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    // Default Constructor
    public HotelBooking()
    {
        GuestName = "Unknown";
        RoomType = "Standard";
        Nights = 1;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy Constructor
    public HotelBooking(HotelBooking hb)
    {
        GuestName = hb.GuestName;
        RoomType = hb.RoomType;
        Nights = hb.Nights;
    }

    public void DisplayBooking()
    {
        Console.WriteLine("Guest: {0}, Room: {1}, Nights: {1}",GuestName,RoomType,Nights);
    }

    static void Main()
    {
        HotelBooking booking1 = new HotelBooking("Ram", "Deluxe", 3);
        HotelBooking booking2 = new HotelBooking(booking1);

        booking1.DisplayBooking();
        booking2.DisplayBooking();
    }
}
