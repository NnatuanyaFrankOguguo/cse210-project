using System;

public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>();
    private List<string> _prompts = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        AddLists();
    }

    private void AddLists()
    {
        _prompts.Add("Think of a time when you stood up for someone else?");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something trully");

        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing this about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("how can you keep this experience in mind for the future? ");
    }

    private string GetRandomPrompt()
    {
        Random atRandom = new Random();
        int randomIndex = atRandom.Next(0, _prompts.Count);
        string randomPrompts = _prompts[randomIndex];
        return randomPrompts;

    }

    private string GetRandomQuestions()
    {
        Random atRandom = new Random();
        int randomIndex = atRandom.Next(0, _questions.Count);
        string randomQuestions = _questions[randomIndex];
        _questions.RemoveAt(randomIndex);
        return randomQuestions;
    }

    public void DisplayPrompts()
    { 
        Console.Write("--- ");
        Console.Write(GetRandomPrompt());
        Console.Write(" ---");
        Console.WriteLine("");
    }

    public void DisplayQuestions()
    {
        Console.Write($"{GetRandomQuestions()}");
        ShowCountDown(6);
        Console.WriteLine("");
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
        Console.WriteLine("Consider the following Prompt: ");
        Console.WriteLine("");
        DisplayPrompts();
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue ");
        string userAnswer = Console.ReadLine();

        if(string.IsNullOrEmpty(userAnswer))
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(response);
            Console.WriteLine("");
            Console.WriteLine("Now ponder on each of the following questions as they relates to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(6);
            Console.Clear();
            while(DateTime.Now < endTime)
            {
               DisplayQuestions();    
            }
            DisplayEndingMessage();
        }

       

        
    }



}