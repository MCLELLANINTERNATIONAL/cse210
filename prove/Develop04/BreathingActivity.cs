using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
       _name = "Breathing Activity";
       _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe In");
            ShowCountDown(5);
            Console.WriteLine("Breathe Out");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}
