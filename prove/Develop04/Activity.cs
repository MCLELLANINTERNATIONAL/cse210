using System;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;
    
    public Activity() 
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        //Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        //Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner!");
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Count Down!");
    }
}