using System;
using System.Collections.Generic;

class Program // Program 1: abstraction with videos
{
    
    static void Main(string[] args)
    {
        Console.Clear(); // i hate looking at the stuff from the compiler
        List<Video> videos = new List<Video>();

        // 3-4 videos with comments, everything will be hard coded for simplicity. no user interfaces.
        Video video1 = new Video("Monkey pees in own mouth", "Mad for Monkeys", 600);
        video1.AddComment("John", "Great tutorial!");
        video1.AddComment("Dave", "Im more of a visual learner, thanks for the vid, I needed this!!");
        video1.AddComment("Bob", "Finally something to tyr this weekend!");

        Video video2 = new Video("Wood Working for Idiots", "Paul Bunion", 720);
        video2.AddComment("Dude", "Nice Vid!");
        video2.AddComment("Alex", "Any more of this?");
        video2.AddComment("Emily", "Are there any good uses for all the left over saw dust?");

        Video video3 = new Video("Stuff happens", "Forest Gump", 900);
        video3.AddComment("Guy 1", "Watch your step! Never mind.");
        video3.AddComment("Guy 2", "Glad hes not wearing my shoes!");
        video3.AddComment("Guy3", "That would go great on a bumper sticker...");

        videos.AddRange(new[] { video1, video2, video3 });

        // displaying information for each video
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
