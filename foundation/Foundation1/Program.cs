using System;

class Program
{
    static void Main(string[] args)
    {
        // Video video1= new Video();
        // video1._title = "Love songs";
        // video1._author = "James Cameron";
        // video1._length = "10secs";
        // video1.StoreComments1();
        // video1.GetDisplay();

        Mainvideo iterate = new Mainvideo();
        iterate.StoreVideos();
        iterate.LoadVideos();
        
    }
}