using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        AddLists();
    }

    private void AddLists()
    {
        _prompts.Add("Who are the people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("Who are some of your personal herores?");
        _prompts.Add("When have you felt the promptings of the Holy Ghost this month?");
    }

    private void GetRandomPrompt()
    {
        Random atRandom = new Random();
        int randomIndex = atRandom.Next(0, _prompts.Count);
        string randomPrompts = _prompts[randomIndex];
        Console.WriteLine($"--- {randomPrompts} ---");
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string userResponse = Console.ReadLine();
        userList.Add(userResponse);
        return userList;
    }

    public void Run()
    {
        Console.WriteLine("");
        DisplayStartingMessage();
        Console.WriteLine($"");
       
        Console.WriteLine(_description);
        Console.WriteLine($"");
        Console.Write("How long do you want this session to last? ");
        int response = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner(6);
        Console.WriteLine("");
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following  prompts: ");
        Console.WriteLine("");
        GetRandomPrompt();
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(6);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(response);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            GetListFromUser();
            _count++;
        }

        Console.WriteLine($"You have listed {_count} items");
        DisplayEndingMessage();
    }





}