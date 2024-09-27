using System;

public class Promptgenerator
{
    public List<string> _promptLists= new List<string>();



    public string GetRandomPrompt()
    {   
        Random atRandom = new Random();
        int randomIndex = atRandom.Next(0, _promptLists.Count);  // Generates a random index between 0 and the size of the list - 1
        string randomPrompt = _promptLists[randomIndex];  // Retrieves a random ._promptText from the list of Entry
        //Console.WriteLine(randomPrompt);
        return  randomPrompt;
    }
}