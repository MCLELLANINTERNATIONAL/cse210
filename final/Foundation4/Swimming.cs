using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    protected int _laps; // Number of laps

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0;

    public override double GetSpeed() => GetDistance() / DurationInMinutes * 60.0;

    public override double GetPace() => DurationInMinutes / GetDistance();
}
