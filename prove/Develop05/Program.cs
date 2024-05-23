using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        Console.WriteLine("Welcome to the Eternal Quest Goal Tracker!");
        string choice;

        do
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
        switch (choice)
            {
                case "1":
                    AddGoal(goalManager);
                    break;
                case "2":
                    RecordGoalEvent(goalManager);
                    break;
                case "3":
                    DisplayGoals(goalManager);
                    break;
                case "4":
                    LoadGoals(goalManager);
                    Console.WriteLine("Congratulations, your goals have been loaded!");
                    break;
                case "5":
                    SaveGoals(goalManager);
                    Console.WriteLine("Congratulations, your goals have been saved!");
                    break;
                case "6":
                    Console.WriteLine("Exiting the Goal Tracker Program!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        } while (choice != "6");
    }

    static void AddGoal(GoalManager goalManager)
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
            goalManager.AddGoal(goal);
            Console.WriteLine("Goal added successfully.");
        }
        else
        {
            Console.WriteLine("Failed to add goal. Please check the inputs and try again.");
        }
    }

    static void RecordGoalEvent(GoalManager goalManager)
    {
        Console.Write("Enter the index of the goal to record: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;
        goalManager.RecordGoalEvent(index);
        Console.WriteLine("Event recorded.");
    }

    static void DisplayGoals(GoalManager goalManager)
    {
        Console.WriteLine("Current Goals:");
        Console.WriteLine(goalManager.DisplayGoals());
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the file name from which to load goals: ");
        string GoalJournal = Console.ReadLine();
        goalManager.LoadGoals(GoalJournal);
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the file name to save goals to: ");
        string GoalJournal = Console.ReadLine();
        goalManager.SaveGoals(GoalJournal);
    }
}