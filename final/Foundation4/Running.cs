using System;
using System.Collections.Generic;

public class Running : Activity
{
    protected double _distance; // Distance in kilometers

    public Running(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / DurationInMinutes) * 60;

    public override double GetPace() => DurationInMinutes / _distance;
}