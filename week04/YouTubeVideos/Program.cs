using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all Video objects
        List<Video> videos = new List<Video>();

        // --- Video 1 ---
        Video video1 = new Video("How to Make Sourdough Bread", "BreadBakingChannel", 742);
        video1.AddComment(new Comment("Carlos Mendez", "This recipe changed my life!"));
        video1.AddComment(new Comment("Julia Roberts", "I tried it and it came out perfect, thank you!"));
        video1.AddComment(new Comment("Mike Thompson", "Finally a tutorial that explains hydration ratios."));
        video1.AddComment(new Comment("Ana Lucia", "Best bread I have ever made, subscribed!"));
        videos.Add(video1);

        // --- Video 2 ---
        Video video2 = new Video("C# Object-Oriented Programming for Beginners", "CodeWithMike", 1530);
        video2.AddComment(new Comment("Sara Kim", "This helped me understand classes so much better."));
        video2.AddComment(new Comment("David Okafor", "Great explanation of encapsulation, keep it up!"));
        video2.AddComment(new Comment("Emily Chen", "I wish I had found this video at the start of my course."));
        videos.Add(video2);

        // --- Video 3 ---
        Video video3 = new Video("Top 10 Hiking Trails in Patagonia", "WildExplorer", 895);
        video3.AddComment(new Comment("Lucas Fernandez", "Visited trail number 3 last summer, absolutely stunning!"));
        video3.AddComment(new Comment("Priya Nair", "Adding all of these to my bucket list right now."));
        video3.AddComment(new Comment("Tom Eriksson", "Great footage, what camera do you use?"));
        videos.Add(video3);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine($"Title:    {video.GetTitle()}");
            Console.WriteLine($"Author:   {video.GetAuthor()}");
            Console.WriteLine($"Length:   {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("-------------------------------------------------");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
