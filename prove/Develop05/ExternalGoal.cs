using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override bool IsComplete() => false;  // Eternal goals never complete

    public override void RecordEvent()
    {
        // Points could be added to a user's total score here
    }

    public override string GetDetailsString() => "Ongoing";

    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}
