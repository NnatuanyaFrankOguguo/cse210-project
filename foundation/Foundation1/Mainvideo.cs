using System;

public class Mainvideo
{
    public List<Video> _videosList = new List<Video>();
    public List<Comment> _comments = new List<Comment>();

    public void StoreVideos()
    {

        Video video1 = new Video("Love songs","James Cameron","10secs");
        video1.AddComment(new Comment("Evelyn", "funny videos"));
        video1.AddComment(new Comment("John", "Trash videos"));
        video1.AddComment(new Comment("Jane", "cute videos"));

        Video video2 = new Video("Sad songs","Emily bothers","20secs");
        video2.AddComment(new Comment("Jeremy", "sad but deep"));
        video2.AddComment(new Comment("Emily", "melancholic vibe"));
        video2.AddComment(new Comment("Bob", "emotionally touching"));

        Video video3 = new Video("Kids songs","Frank jones","15secs");
        video3.AddComment(new Comment("Kelly", "my kids love it"));
        video3.AddComment(new Comment("Claire", "very catchy"));
        video3.AddComment(new Comment("Bush", "bright and fun"));
        // _videosList.Add(new Video("Love songs","James Cameron","10secs"));

        _videosList.Add(video1);
        _videosList.Add(video2);
        _videosList.Add(video3);
    }

    public void LoadVideos()
    {
        foreach (Video video in _videosList){
            Console.WriteLine($" Title: {video._title}\n Author: {video._author}\n Length: {video._length} \n Comments:  ");
            foreach (Comment comment in video._comments1)
            {
                Console.WriteLine($"Name : {comment._name} \nComment: {comment._textComment}");
            }
            Console.WriteLine("");
            
        }
    }
}