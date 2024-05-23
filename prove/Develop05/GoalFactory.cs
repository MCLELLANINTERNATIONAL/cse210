using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class GoalFactory
{
    public static Goal CreateGoal(string serializedGoal)
    {
        string[] parts = serializedGoal.Split(':');
        string type = parts[0];
        string details = parts[1];

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(details);
            case "EternalGoal":
                return new EternalGoal(details);
            case "ChecklistGoal":
                return new ChecklistGoal(details);
            default:
                return null;
        }
    }
}