using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public static EternalGoal FromString(string details)
    {
        var parts = details.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        return new EternalGoal(name, description, points);
    }

    public override bool IsComplete() => false;  // Eternal goals never complete

    public override void RecordEvent(GoalManager manager)
    {
        // Points added to a user's total score here
        manager.AddPoints(_points);
    }

    public override string GetDetailsString() => $"EternalGoal: {_shortName}, Ongoing";

    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}

