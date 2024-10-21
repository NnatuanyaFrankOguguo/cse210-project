using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string decription, int duration) : base(name,decription,duration)
    {
        
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
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(response);
        //adding a condition if the user wanted a longer session the pace of the breathing technique will change after the third iteration
        int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath In ...");
            ShowCountDown(2);
            Console.Write("Breath Out ...");
            ShowCountDown(3);          
            Console.WriteLine("");
            Console.WriteLine("");
            i++;
            if(i>=3 && response >= 60)
            {
                while(DateTime.Now < endTime)
                {
                    Console.WriteLine("");
                    Console.Write("Breath In ...");
                    ShowCountDown(3);
                    Console.WriteLine("HOLD IT!!!");
                    Thread.Sleep(3000);
                    Console.Write("Breath Out ...");
                    ShowCountDown(4);
                    Console.WriteLine("");
                }  
            }    
        }
        DisplayEndingMessage();

        
    }
   
}