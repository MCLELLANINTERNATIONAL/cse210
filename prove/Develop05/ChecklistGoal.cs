using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public static ChecklistGoal FromString(string details)
    {
        var parts = details.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int target = int.Parse(parts[3]);
        int amountCompleted = int.Parse(parts[4]);
        int bonus = int.Parse(parts[5]);
        var goal = new ChecklistGoal(name, description, points, target, bonus);
        goal._amountCompleted = amountCompleted;
        return goal;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override void RecordEvent(GoalManager manager)
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            // Add bonus if completed
            if (_amountCompleted == _target)
            {
                _points += _bonus;// bonus points added here
            }
        }
    }

    public override string GetDetailsString() => $"Completed {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus}";
}