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
                return SimpleGoal.FromString(details);
            case "EternalGoal":
                return EternalGoal.FromString(details);
            case "ChecklistGoal":
                return ChecklistGoal.FromString(details);
            default:
                return null;
        }
    }
}