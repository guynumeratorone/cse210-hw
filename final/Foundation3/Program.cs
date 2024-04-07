using System;

class Program //Program 3: Inheritance with Event Planning

{
    static void Main(string[] args) 
    {   
        Console.Clear();
        Address address1 = new Address("123 Main St", "Anytown", "ID", "USA");
        Address address2 = new Address("123 Boardwalk Ave", "Othercity", "CO", "USA");

        TimeSpan time1 = new TimeSpan(14, 0, 0); // 14:00 (2:00 PM)
        TimeSpan time2 = new TimeSpan(18, 0, 0); // 18:00 (6:00 PM)
        TimeSpan time3 = new TimeSpan(12, 0, 0); // 12:00 (12:00 PM)

        Event lecture = new Lecture("Dont be a fool 101", "Technology", new DateTime(2024, 4, 10), time1, address1, "Guy 1", 50);
        Event reception = new Reception("Huge Party", "Massive Party", new DateTime(2024, 5, 15), time2, address2, "Youremailehere@email.com");
        Event outdoorGathering = new OutdoorGathering("Canable BBQ", "Enjoy a day in the sun", new DateTime(2024, 6, 20), time3, address1, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}

public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) 
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

