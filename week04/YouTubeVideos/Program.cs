using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Minecraft: 20 More Doors In 100 Seconds","Mumbo Jumbo",106);
        Video video2 = new Video("Minecraft: 20 Doors In 100 Seconds","Mumbo Jumbo",113);
        Video video3 = new Video("I Made a Safe House in Minecraft","Mumbo Jumbo",812);

        video1.AddComment("Yukillion","Ah yes, back when Mumbo still talks in seconds instead of ticks.");
        video1.AddComment("nerishshrestha356","I like the part where he opens the door.");
        video1.AddComment("thefryedrooster9153","he should recreate this but a more recent version");

        video2.AddComment("gopherguts2183","I liked how he killed himself to transfer to even-width doors without it looking weird.");
        video2.AddComment("karlvx1000","The last one was the best and most complex out of all of them");
        video2.AddComment("edragoninja317","A lot of villagers liked this vid");

        video3.AddComment("ThatMumboJumbo","I built this as a fun project, just like all things in Minecraft, it can be defeated by a determined kid with a pickaxe! That's what makes this game great! 😂");
        video3.AddComment("that_ep1cness","Imagine being the mailman of this house");
        video3.AddComment("yes8874","When mumbo realizes that he is on a single player world");
        video3.AddComment("smollo7849","Imagine going to someones house and hearing “deploy the defense creepers”");

        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayTitle());
            Console.WriteLine(video.DisplayLength());
            Console.WriteLine($"Comments: {video.NumberOfComments()}");
            Console.WriteLine();
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayName());
                Console.WriteLine(comment.DisplayText());
                Console.WriteLine();
            }
        }
    }
}