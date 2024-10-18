using System;

public class Math : Assignment
{
    private string _textbook;
    private string _problems;

    public Math(string name, string topic, string textbook, string problem) : base(name,topic)
    {
        _textbook = textbook;
        _problems = problem;
    } 

    public string GetHomeworkList()
    {
        return $"{_name} - {_topic} \n{_textbook} {_problems}";
    }
}