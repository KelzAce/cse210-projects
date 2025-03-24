using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Video objects
        Video video1 = new Video("C# Tutorial for Beginners", "John Doe", 600);
        Video video2 = new Video("How to Cook Pasta", "Chef Lisa", 450);
        Video video3 = new Video("The Science of Space", "Dr. Albert", 720);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very informative, thanks!"));
        video1.AddComment(new Comment("Charlie", "Helped me a lot, keep it up!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Dave", "Tried this recipe, it's amazing!"));
        video2.AddComment(new Comment("Eve", "Simple and delicious!"));
        video2.AddComment(new Comment("Frank", "What brand of pasta do you recommend?"));

        // Add comments to video 3
        video3.AddComment(new Comment("Grace", "Mind-blowing facts!"));
        video3.AddComment(new Comment("Henry", "I love space science."));
        video3.AddComment(new Comment("Ivy", "Could you make a video on black holes?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details of all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}