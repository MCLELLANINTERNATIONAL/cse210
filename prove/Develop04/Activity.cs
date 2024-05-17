using System;
using System.Collections.Generic;
using System.Threading;

// Added the accumalatiom of the number count you have done per choice.
// Added a display of how many seconds was inputed in the previous activity, at the start of a new selection, added as an inheritance in the base 'Activity" class.

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public static Dictionary<string, int> activityCount = new Dictionary<string, int>();

    public Activity()
    {
        if (!activityCount.ContainsKey(this.GetType().Name))
        {
            activityCount[this.GetType().Name] = 0;
        }
    }
        
    public void DisplayStartingMessage()
    {
        activityCount[this.GetType().Name]++;
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}. This has been run {activityCount[this.GetType().Name]} times.");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Prepare to begin {_name}");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.WriteLine(); // Move to next line after spinner
    }

    public void ShowCountDown(int seconds)
    {
        for (int i=1; i<=seconds;i++)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}