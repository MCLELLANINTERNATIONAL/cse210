using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public List<Goal> GetGoals() => _goals;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        UpdateScore(goal);
    }

    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            // Assuming that RecordEvent method in Goal might need access to GoalManager
            _goals[goalIndex].RecordEvent(this);
        }
        else
        {
            throw new ArgumentException("Invalid goal index.");
        }
    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    private void UpdateScore(Goal goal)
    {
        if (goal.IsComplete())
        {
            _score += goal.Points; // 
        }
    }

    public string DisplayGoals()
    {
        StringBuilder builder = new StringBuilder();
        foreach (var goal in _goals)
        {
            builder.AppendLine(goal.GetDetailsString());
        }
        return builder.ToString();
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
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
}