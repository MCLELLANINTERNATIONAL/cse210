using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) 
        {
            _isComplete = false;
        }

    public static SimpleGoal FromString(string details)
    {
        var parts = details.Split(',');
        if (parts.Length < 4) return null; // Ensure there are enough parts

        string name = parts[0];
        string description = parts[1];
        if (!int.TryParse(parts[2], out int points)) return null; // Safe parsing
        if (!bool.TryParse(parts[3], out bool isComplete)) return null; // Safe parsing

        var goal = new SimpleGoal(name, description, points);
        goal._isComplete = isComplete;
        return goal;
    }

    public override bool IsComplete() => _isComplete;

    public override void RecordEvent(GoalManager manager)
    {
        if (!_isComplete) // Only mark complete and add points if not already completed
        {
            _isComplete = true;
            manager.AddPoints(this.Points); // Assuming points should be added on completion
        }
    }

    public override string GetDetailsString() => $"SimpleGoal: {_shortName}, Complete: {_isComplete}";

    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}