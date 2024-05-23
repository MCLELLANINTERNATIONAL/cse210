using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public EternalGoal(string details)
    {
        parts = details.Split(',');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        return new EternalGoal(_shortName, _description, _points);
    }

    public override int RecordEvent()
    {
        // Points added to a user's total score here
        // PUT message
        Console.WriteLine($"Congratulations you have earned {_points}!!");
        return _points;
    }

    public override string GetDetailsString() => $"EternalGoal: {_shortName}, Ongoing";

    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}

