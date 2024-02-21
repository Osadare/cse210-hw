//Abstraction with YouTube Video project. I have made significant strides in designing a class that effectively tracks YouTube videos and comments. 
using System;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Tutorial videos");
        Console.WriteLine();

       List<Video> videos = new List<Video>();

    Video video1 = new Video("Introduction to C#", "John Smith", 20);
    video1.AddComment("Eva", "Awesome tutorial!");
    video1.AddComment("Frank", "Very informative, thanks!");
    video1.AddComment("Grace", "I gained a lot of knowledge, thank you!");
    videos.Add(video1);

    Video video2 = new Video("Advanced Python Programming", "Sarah Johnson", 45);
    video2.AddComment("Henry", "This was amazing!");
    video2.AddComment("Ivy", "How did you accomplish that last part?");
    video2.AddComment("Jack", "That clarifies everything!");
    videos.Add(video2);

    Video video3 = new Video("Web Development with HTML and CSS", "Emily Thompson", 60);
    video3.AddComment("Kate", "Thanks for sharing!");
    video3.AddComment("Liam", "nice tutorial");
    video3.AddComment("Mia", "Great job.");
    videos.Add(video3);

    Video video4 = new Video("Machine Learning Basics", "Alex Turner", 25);
    video4.AddComment("Noah", "So cool!");
    video4.AddComment("Olivia", "Love it.");
    video4.AddComment("Parker", "I'm still not quite grasping it...");
    videos.Add(video4);

    foreach (Video video in videos)
    {
        video.DisplayInfo();
        Console.WriteLine("--------");
        Console.WriteLine();
    }
}
    }
