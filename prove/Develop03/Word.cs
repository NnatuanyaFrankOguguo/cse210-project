using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; //by default
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {   
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden; //returning the current state of _isHidden whether true or false
    }

    public string GetDisplayText()
    {
        if(IsHidden())
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }
}

// or this return _isHidden ? "_____" : _text;