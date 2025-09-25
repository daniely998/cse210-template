using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("First Time at the Zoo", "Jenny Powler", 123);
        video1.AddComment("peteman73", "Awesome stuff");
        video1.AddComment("Claire Sinclair", "I love going to the zoo!");
        video1.AddComment("Vazier761", "What the panda doing");
        _videos.Add(video1);

        Video video2 = new Video("Shape of Magic", "Cranky2", 311);
        video2.AddComment("Yolarun", "first");
        video2.AddComment("megaphone", "Another MASTERPIECE by cranky. Keep up the good work my man");
        video2.AddComment("peteman73", "Awesome stuff");
        video2.AddComment("RestAsure", "LOVE DIS");
        _videos.Add(video2);

        Video video3 = new Video("How to Open A Door", "mastermind41", 9);
        video3.AddComment("JoeShin", "Needed this thx");
        video3.AddComment("peteman73", "Awesome stuff");
        video3.AddComment("sillygoose03", "replying to peteman73: Why are you everywhere?");
        video3.AddComment("King_Steve", "replying to peteman73: Bot");
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            Console.WriteLine(video.Display());
        }
    }
}