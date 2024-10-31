using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _duration;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}