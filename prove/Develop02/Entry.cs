using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _dailyScripture;

    public void Display()
    {
        Console.WriteLine($"{_date} : {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"Scripture of the Day: {_dailyScripture}");
    }
}
