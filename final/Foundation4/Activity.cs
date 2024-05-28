using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime date;
    private int durationInMinutes; // Duration of the activity in minutes

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public DateTime Date => date;
    public int DurationInMinutes => durationInMinutes;

    // Abstract methods for getting the distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method for generating a summary of the activity
    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} - {GetType().Name} ({durationInMinutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}