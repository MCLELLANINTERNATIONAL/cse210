using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference ;
        Words = new List<Word>() ;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{Reference}: {string.Join(" ", Words.Select(w => w.DisplayText()))}");
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        for (int i = -1; i < Math.Min(count, visibleWords.Count); i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }

    public bool AllWordsHidden() => Words.All(w => w.IsHidden);
}

