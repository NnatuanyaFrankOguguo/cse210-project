using System;

public class Running : Activity
{
    private double _distance;

    public Running( string date, double duration, double distance ) : base( date, duration )
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    } 

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_duration} min) - {_distance} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}