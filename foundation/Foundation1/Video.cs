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



//   public int TotalComments() 
//   {
//     int totalNumber = _comments.Count;
//     return totalNumber;
//   }

//   public void GetDisplay()
//   {
//     Console.WriteLine($"Title: {_title}\n Author: {_author} \n Length: {_length} \n Comments: {TotalComments()} ");
//     foreach (Comment comment in _comments)
//     {
//         Console.WriteLine($"Name : {comment._name} , Comments: {comment._textComment}");
//     }
//   }

     
}