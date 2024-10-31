using System;

public abstract class Activity
{
    protected string _date;

    protected double _duration;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }


    public abstract double GetDistance();
  

    public abstract double GetSpeed();
   

    public abstract double GetPace();


    public abstract string GetSummary();
}