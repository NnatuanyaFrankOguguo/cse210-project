using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private List<string> _scriptureText = new List<string>();
    private List<Reference> _referenceList = new List<Reference>();

    public Scripture()
    { 
        ReferenceScriptureText(); // Initialize scripture texts and references
        (Reference reference, string scripture) = RandomScriptureText(); // Get a random scripture and reference
        _reference = reference; // Set the reference
        InitializeWords(scripture); // Initialize words for the selected scripture // add the function as contructor when the main program starts running this will execute
    }

    private void ReferenceScriptureText()
    {
        _scriptureText.Add("Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight");
        _referenceList.Add(new Reference("Proverbs", 3, 5, 6));

        _scriptureText.Add("For I am not ashamed of the gospel of Christ: for it is the power of God to salvation to every one that believes; to the Jew first, and also to the Greek");
        _referenceList.Add(new Reference("Romans", 1, 16));

        _scriptureText.Add("Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");
        _referenceList.Add(new Reference("Alma", 37, 37));

        _scriptureText.Add("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        _referenceList.Add(new Reference("1 Nephi", 3, 7));
    }



    public (Reference reference, string scripture) RandomScriptureText()
    {
        Random atRandom = new Random(); 
        int randomIndex = atRandom.Next(0, _scriptureText.Count); 
        string randomScripture = _scriptureText[randomIndex]; 
        Reference randomReference = _referenceList[randomIndex]; 
        return (randomReference, randomScripture); 
    }

     private void InitializeWords(string scripture)
    {
        string[] splitWords = scripture.Split(' '); // Split the scripture text into words

        foreach (string word in splitWords) // Loop through each word
        {
            _words.Add(new Word(word)); // Create a Word object for each word and add to the _words list
        }
    }


    public Scripture(Reference reference, string scriptureTexts = null)
    {
        _reference = reference;
        string textToUse = scriptureTexts ?? RandomScriptureText().scripture; //The ?? operator is called the "null-coalescing operator". It checks if scriptureTexts is null. if yes then the list would show 
        string[] splitWords = textToUse.Split(' '); // Spliting the scripture texts parameters into words based on present spaces and adding them to an array splitwords 

        foreach (string word in splitWords)//looping through the individual word in the splitsword array
        {
            _words.Add(new Word(word)); // Create a Word object for each word and add to the list(this is so, that it can be turn to Hidden(__) or show(text) individually while also displaying others)
        }
    }

public void HideRandomWords(int numbersToHide)
{
    Random atRandom = new Random();

    // making sure not to hide more words than available
    int wordsToHide = Math.Min(numbersToHide, _words.Count - CountHiddenWords()); 

    int hiddenCount = 0;

    while (hiddenCount < wordsToHide)
    {
        int randomIndex = atRandom.Next(_words.Count);

        if (!_words[randomIndex].IsHidden()) // Check if the word is already hidden
        {
            _words[randomIndex].Hide(); // Hide the word
            hiddenCount++;
        }
    }
}


private int CountHiddenWords() //to know how many words are hidden..so i dont hide more words than whats left
{
    int count = 0;
    foreach (Word word in _words)
    {
        if (word.IsHidden())
        {
            count++;
        }
    }
    return count;
}

    public string GetDisplayText()
    {
        //When i create a Scripture object, i already initialize the _reference with a Reference instance: which the constructor takes as parameter(reference) and assigns it to the _reference
        string referenceText = _reference.GetDisplay(); //stores the Reference getdisplay method in a variable reference text
        List<string> wordsDisplay = new List<string>(); //creating a new list to add each individual words from the class list of Word

        foreach (Word word in _words)
        {
            wordsDisplay.Add(word.GetDisplayText()); //with the getDisplayText its adding each word if its hidden(___) or if its not(text) 
        }

        string scriptureText = string.Join(" ", wordsDisplay); //then making each individual words whether hidden or not that has been added to the list become a single string back
        // Return the formatted output with the reference and scripture text
        return $"{referenceText} : {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words) //iterating through the class Words of word list to check if all the words isHidden is true or not pass false to once everything runs again it will loop till all words are hidden then isHidden becomes true to end the code 
        {
            if (!word.IsHidden())
            {
                return false; // If at least one word is not hidden, return false
            }
        }
        return true; // All words are hidden
    }
}
