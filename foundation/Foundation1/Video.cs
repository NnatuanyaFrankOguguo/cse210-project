using System;

public class Video
{
  public string _title;
  public string _author;
  public string _length;

 public List<Comment> _comments1 = new List<Comment>();

  public Video(string title, string author, string length)
  {
    _title = title;
    _author = author;
    _length = length;
  }


  public void AddComment(Comment comment)
  {
    _comments1.Add(comment);
 
  }

    // for each new video class created multiple comments will be able to be added in the comment list using this method
     
}