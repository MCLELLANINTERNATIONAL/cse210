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

    public override bool IsComplete() => _amountCompleted >= _target;

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            // Add bonus if completed
            if (_amountCompleted == _target)
            {
                // bonus points could be added here
            }
        }
    }

    public override string GetDetailsString() => $"Completed {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus}";
}