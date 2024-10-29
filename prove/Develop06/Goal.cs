using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected bool _isComplete;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    

    public abstract bool IsComplete();

    public abstract string GetDetailsString();
    
        // Create a string that combines the details
        //return $"Goal: {_shortName} Description: {_description} ---({_points} points awarded every time.)";
    

    public abstract string GetStringRepresentation();
}