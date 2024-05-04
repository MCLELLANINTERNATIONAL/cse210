using System;
using System.Collections.Generic;
using System.IO;

// Added object and method for daily scripture to write enrty and display all 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Random random = new Random();
    public PromptGenerator pgen = new PromptGenerator();
    public DailyScripture scriptureGenerator = new DailyScripture();

    public void WriteEntry()
    {
        Entry entry = new Entry();
        entry._promptText = pgen.GetRandomPrompt();
        entry._dailyScripture = scriptureGenerator.GetRandomScripture();
        Console.WriteLine($"Today's prompt: {entry._promptText}");
        Console.WriteLine($"Scripture of the Day: {entry._dailyScripture}");
        Console.Write("Your response: ");
        entry._entryText = Console.ReadLine();
        entry._date = DateTime.Now.ToShortDateString();
        _entries.Add(entry);
        Console.WriteLine("Congratulations! Your entry has been added to your journal!");
    }

    public void DisplayAll()
    {
        // Display all of the entries in the entries list
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string myJournal)
    {
        // Loop through each item in _entries and save it in a file, added daily scripture
        try
        {
            using (StreamWriter outputFile = new StreamWriter(myJournal))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText} | {entry._dailyScripture}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void LoadFromFile(string Program)
    {
        //Loop through each line of the file and create Entry objects to put in, added daily scripture
        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(Program);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    Entry entry = new Entry()
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2],
                        _dailyScripture = parts[3]
                    };
                    _entries.Add(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
