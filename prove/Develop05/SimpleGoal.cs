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

    public override bool IsComplete()
    { 
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetDetailsString()
    {
        return $"Complete: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
       return $"SimpleGoal:{_shortName},{_description},{_points}";
    }
}