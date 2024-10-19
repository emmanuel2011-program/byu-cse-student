using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to Youtube Videos!\n");

        List<Video> videos = new List<Video>();

        void DisplayVideoData()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine($"Video0{count} - 4K");
                video.DisplayMetaData();
                Console.WriteLine("\nComments:");
                video.DisplayComments(); // Change from DisplayComment to DisplayComments
            }
        }

        // Instantiating the Video objects
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        // Instantiating the Comment class
        Comment comment = new Comment("Samuel", "This part is great");

        // Video1
        video1.SetVideoMeta("Peter McKinnon", "Making Epic B-Rolls", 10);
        video1.AddComment(comment); // Change from SetComment to AddComment
        comment = new Comment("Jerry", "Love it ❤️");
        video1.AddComment(comment);
        comment = new Comment("Abigail", "Peter never disappoints");
        video1.AddComment(comment);
        videos.Add(video1);

        // Video2
        video2.SetVideoMeta("Enes Yilmazer", "$20,000,000 Beverly Hill Mansion", 30);
        comment = new Comment("Zepora", "Modern luxury living");
        video2.AddComment(comment);
        comment = new Comment("Josephine", "What a home");
        video2.AddComment(comment);
        comment = new Comment("Henry", "That's too much house for me 😃");
        video2.AddComment(comment);
        videos.Add(video2);

        // Video3
        video3.SetVideoMeta("Cobla Sean", "Day in the Life of a programmer", 10);
        comment = new Comment("Dews", "More of these videos 👍🏽");
        video3.AddComment(comment);
        comment = new Comment("Jane Fox", "Is it all coffee and great views?");
        video3.AddComment(comment);
        comment = new Comment("Stephen Seagal", "Love the video Chris 🫡");
        video3.AddComment(comment);
        videos.Add(video3);

        DisplayVideoData();
    }
}

    
   


