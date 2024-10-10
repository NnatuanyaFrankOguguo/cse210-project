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
}