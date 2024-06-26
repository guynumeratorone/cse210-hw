public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString(@"hh\:mm")}\nAddress: {address.GetAddressDetails()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type of Event: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
    
}

