using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime _date;
    protected int _durationInMinutes; // Duration of the activity in minutes

    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public DateTime Date => _date;
    public int DurationInMinutes => _durationInMinutes;

    // Abstract methods for getting the distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method for generating a summary of the activity
    public string GetSummary()
    {
        return $"\n{_date:dd MMM yyyy} - {GetType().Name} ({_durationInMinutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km\n";
    }
}