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
       // _parts = details.Split(',');
       // _shortName = parts[0];
       // _description = parts[1];
       //_points = int.Parse(parts[2]);
       //return new EternalGoal(_shortName, _description, _points);
        
        var parts = details.Split(',');
        if (parts.Length != 3)
        {
            throw new ArgumentException("Details must be a comma-separated string with exactly three parts.");
        }

        _shortName = parts[0];
        _description = parts[1];

        if (!int.TryParse(parts[2], out _points))
        {
            throw new FormatException("The points part of the details string is not a valid integer.");
        }
    }

    public override int RecordEvent()
    {
        // Points added to a user's total score here
        Console.WriteLine($"Congratulations you have earned {_points} points!");
        return _points;   
    }

    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}

