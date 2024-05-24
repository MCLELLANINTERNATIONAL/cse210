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

    public SimpleGoal(string details)
    {
        var parts = details.Split(',');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _isComplete = bool.Parse(parts[3]);
        
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;  // Return the number of points added  // Return 0 if no points are added because the goal was already complete
    }   

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}" ;
    }

}