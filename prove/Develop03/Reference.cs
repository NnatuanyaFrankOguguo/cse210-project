using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse; //? it allows to know when an endVerse is provided or not

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
       
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplay()
    {
        if(_endVerse.HasValue)//to know if an endVerse has a value or not
        {
            string theBookOf = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return theBookOf;
        }
        else 
        {
            string theBookOf = $"{_book} {_chapter}:{_verse}";
            return theBookOf;
        }
        
    }



}