using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}