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
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool isComplete = bool.Parse(parts[3]);
        var goal = new SimpleGoal(name, description, points);
        goal._isComplete = isComplete;
        return goal;
    }

    public override bool IsComplete() => _isComplete;

    public override void RecordEvent(GoalManager manager)
    {
        _isComplete = true;
    }

    public override string GetDetailsString() => $"SimpleGoal: {_shortName}, Complete: {_isComplete}";

    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName},{_description},{_points}";
 
    /*public override bool IsComplete()
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
    }*/
}