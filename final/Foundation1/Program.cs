using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video> {
            new Video("Introduction to C#", "Programming Academy", 300),
            new Video("Advanced C# Techniques", "Code Guru", 540),
            new Video("C# Interfaces Explained", "Tech Educator", 480)
        };

        videos[0].AddComment(new Comment("John Doe", "Great introduction!"));
        videos[0].AddComment(new Comment("Jane Smith", "Very helpful, thanks!"));

        videos[1].AddComment(new Comment("Alice Johnson", "So many good tips!"));
        videos[1].AddComment(new Comment("Bob Brown", "Clear and concise."));

        videos[2].AddComment(new Comment("Charlie Davis", "Now I get interfaces!"));
        videos[2].AddComment(new Comment("Dana White", "Perfect explanation."));

        foreach (var video in videos) {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}