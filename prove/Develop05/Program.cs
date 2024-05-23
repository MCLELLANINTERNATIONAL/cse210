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
                    goalManager.AddGoal();
                    break;
                case "2":
                    goalManager.RecordGoalEvent();
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    Console.WriteLine("Congratulations, your goals have been loaded!");
                    break;
                case "5":
                    goalManager.SaveGoals();
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
}