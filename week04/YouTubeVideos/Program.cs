using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C# Programming", "CodeMaster", 1200);
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Bob", "Helped me understand classes better."));
        video1.AddComment(new Comment("Charlie", "Could you make a video on LINQ next?"));
        video1.AddComment(new Comment("Diana", "Awesome content!"));
        videos.Add(video1);

        Video video2 = new Video("Advanced JavaScript Techniques", "WebDevGuru", 1800);
        video2.AddComment(new Comment("Eve", "Mind-blowing concepts!"));
        video2.AddComment(new Comment("Frank", "Learned so much, thanks!"));
        video2.AddComment(new Comment("Grace", "The explanation of closures was perfect."));
        videos.Add(video2);

        Video video3 = new Video("Understanding Data Structures", "AlgoExplorer", 2400);
        video3.AddComment(new Comment("Heidi", "Excellent overview of algorithms."));
        video3.AddComment(new Comment("Ivan", "The visual examples were very helpful."));
        video3.AddComment(new Comment("Judy", "Highly recommend this video!"));
        video3.AddComment(new Comment("Kevin", "When will part 2 be released?"));
        videos.Add(video3);

        Video video4 = new Video("Basics of Cloud Computing", "CloudArchitect", 900);
        video4.AddComment(new Comment("Liam", "Good starting point for beginners."));
        video4.AddComment(new Comment("Mia", "Clear and concise explanations."));
        videos.Add(video4);

        Console.WriteLine("Displaying all video details and comments:");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

        Console.WriteLine("\nProgram execution complete. Press any key to exit.");
        Console.ReadKey();
    }
}
