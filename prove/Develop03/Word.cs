
using System;
using System.Collections.Generic;
using System.Linq;
    
public class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string DisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}
