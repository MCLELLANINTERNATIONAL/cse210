using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
       _name = "Breathing Activity";
       _description = "Breathing Activity. Helps you relax by walking you through breathing in and out slowly.";
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
