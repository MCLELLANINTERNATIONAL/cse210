using System;

// Base Event class
class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _eventDate;
    protected TimeSpan _eventTime;
    protected Address _eventAddress;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = address;
    }

    // Standard details message
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_eventDate.ToShortDateString()}\nTime: {_eventTime.ToString(@"hh\:mm")}\nAddress: {_eventAddress}";
    }

    // Full details message
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();  // Will be overridden in derived classes
    }

    // Short description message
    public string GetShortDescription()
    {
        return $"Event: {this.GetType().Name}\nTitle: {_title}\nDate: {_eventDate.ToShortDateString()}";
    }
}
