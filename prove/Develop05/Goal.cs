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

    protected Goal(){}

    public int Points
    {
        get { return _points; }
        protected set { _points = value; }  // Protected setter to allow modification within derived classes
    }
    
    public virtual bool IsComplete()
    {
        return false;
    }

    public abstract int RecordEvent();
    public virtual string GetDetailsString()
    {
        char tick = IsComplete() ? 'X' : ' ';
        return $"[{tick}] {_shortName} {_description}";
    }
    public abstract string GetStringRepresentation();
}