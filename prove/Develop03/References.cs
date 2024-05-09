using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string _book { get; }
    public int _chapter { get; }
    public int _verse { get; }
    public int? _endingVerse { get; }

    public Reference(string book, int chapter, int verse, int? endingVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endingVerse = endingVerse;
    }

    public override string ToString()
    {
        return _endingVerse == null ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endingVerse}";
    }
}
