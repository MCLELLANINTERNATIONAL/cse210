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

        videos[0].AddComment(new Comment("Kate:", "Great introduction!"));
        videos[0].AddComment(new Comment("Henry:", "Very helpful, thanks!"));

        videos[1].AddComment(new Comment("Alice:", "So many good tips!"));
        videos[1].AddComment(new Comment("Bob:", "Clear and concise."));

        videos[2].AddComment(new Comment("Charlie:", "Now I get interfaces!"));
        videos[2].AddComment(new Comment("Dana:", "Perfect explanation."));

        foreach (var video in videos) {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}