using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string decription, int duration)
    {
        _name = name;
        _description = decription;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the activity of {_name}"); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have done well. You have successfully finished this activity.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinners = new List<string>();
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string s = spinners[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
        }

        if(i >= spinners.Count)
        {
            i = 0;
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    
    }
}