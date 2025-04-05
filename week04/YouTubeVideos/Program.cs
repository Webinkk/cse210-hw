using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating videos
            Video video1 = new Video("How to Code in C#", "John Doe", 120);
            Video video2 = new Video("C# Basics for Beginners", "Jane Smith", 150);
            Video video3 = new Video("Advanced C# Techniques", "Alice Brown", 180);

            video1.Comments.Add(new Comment("Tom", "Great video, learned a lot!"));
            video1.Comments.Add(new Comment("Sue", "I agree, very informative."));
            video1.Comments.Add(new Comment("Jake", "Could you go more into details about loops?"));

            video2.Comments.Add(new Comment("Mary", "Really clear explanation, thanks!"));
            video2.Comments.Add(new Comment("Mark", "I wish there were more examples."));
            video2.Comments.Add(new Comment("Linda", "Nice job!"));

            video3.Comments.Add(new Comment("Ben", "This was a bit advanced for me."));
            video3.Comments.Add(new Comment("Sara", "I learned some great techniques here!"));
            video3.Comments.Add(new Comment("Chris", "Could you explain more about LINQ?"));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");

                foreach (var comment in video.Comments)
                {
                    Console.WriteLine($"\t{comment.CommenterName}: {comment.CommentText}");
                }

                Console.WriteLine();
            }
        }
    }
}
