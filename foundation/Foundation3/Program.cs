using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Running running1 = new Running("31 oct 2024", 5.3, 5.9);
        Swimming swimming1 = new Swimming("30 oct 2024", 150, 50);
        Cycling cycling1 = new Cycling("29 oct 2024", 170, 6.5);

        List<Activity> activities= new List<Activity>();
        activities.Add(running1);
        activities.Add(swimming1);
        activities.Add(cycling1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("");
        }
    }
}