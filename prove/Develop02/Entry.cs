using System;
using System.Collections.Generic;
using System.IO;

//Added Daily Scripture String

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _dailyScripture;

    // Added Daily Scripture to Display()
    public void Display()
    {
        Console.WriteLine($"{_date} : {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"{_dailyScripture}");
    }
}
