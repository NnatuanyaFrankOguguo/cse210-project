using System;

public class Comment
{
    public string _name;
    public string _textComment;

    public Comment(string name, string textComment)
    {
        _name = name;
        _textComment = textComment;
    }
    public string GetDisplay()
    {
        return $"{_name} \n{_textComment}";
    }

    //create a list of Comments in the video class so that a video will be able to contain multiple comments
}