using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public int Score()
    {
        return _score;
    }
    public void RecordGoalEvent()
    {
        Console.Write("Select goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            // Assuming that RecordEvent method in Goal might need access to GoalManager
            if (!_goals[goalIndex].IsComplete())
                _score += _goals[goalIndex].RecordEvent();
            else
                Console.WriteLine("Goal is already compelted");
        }
        else
        {
            throw new ArgumentException("Invalid goal index.");
        }
    }

    public string DisplayGoals()
    {
        //StringBuilder builder = new StringBuilder();
        string text = "";
        int counter = 1;
        foreach (var goal in _goals)
        {
            //builder.AppendLine(goal.GetDetailsString());
            text += counter + ") " + goal.GetDetailsString()+"\n";
            counter++;

        }
        //return builder.ToString();
        return text;
    }

    public void SaveGoals()
    {
        Console.Write("Enter the file name from which to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the file name from which to load goals: ");
        string filename = Console.ReadLine();
        _goals.Clear();
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var goal = GoalFactory.CreateGoal(line);
                if (goal != null)
                    _goals.Add(goal);
            }
        }
    }

    public void AddGoal()
    {
        Console.WriteLine("Select Type of Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Short Name for the Goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Points Value: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal goal = null;
        switch (type)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter Target Number: ");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Bonus Points: ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }
        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal added successfully.");
        }
        else
        {
            Console.WriteLine("Failed to add goal. Please check the inputs and try again.");
        }
    }
}