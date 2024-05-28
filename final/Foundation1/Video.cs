using System;
using System.Collections.Generic;

class Video {
    protected string _title;
    protected string _author;
    protected int _length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment) {
        comments.Add(comment);
    }

    public int GetNumberOfComments() {
        return comments.Count;
    }

    public void DisplayVideoInfo() {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length} seconds");
        Console.WriteLine("Comments:");
        foreach (var comment in comments) {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }
    }
}
