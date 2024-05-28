using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps; // Number of laps

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50) / 1000.0;

    public override double GetSpeed() => GetDistance() / (DurationInMinutes / 60.0);

    public override double GetPace() => DurationInMinutes / GetDistance();
}
