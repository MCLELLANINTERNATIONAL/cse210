using System;
using System.Collections.Generic;

public class Bicycle: Activity
{
    protected double _speed; // Speed in kilometers per hour

    public Bicycle(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * DurationInMinutes) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
