using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        _isComplete = false;
    }

    public ChecklistGoal(string details)
    {
        var parts = details.Split(',');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _amountCompleted = int.Parse(parts[3]);
        _target = int.Parse(parts[4]);
        _bonus = int.Parse(parts[5]);
        _isComplete = bool.Parse(parts[6]);
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override int RecordEvent()
    {
        _amountCompleted++;
        
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations you earned {_points + _bonus} points!");
            _isComplete = true;
            return _points += _bonus;// bonus points added here
        }
        else
            // PUT message
            return _points;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"-- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted}{_target},{_bonus},{_isComplete}";
}