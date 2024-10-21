using System;

class Program
{
    static void Main(string[] args)
    {
        // activity1.Run();
        string response = "";
        while(response != "4" )
        {
            Console.WriteLine("--------------------------WELCOME TO THE MINDFULNESS ACTIVITY-----------------------------------");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflecting Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Console.ReadLine();
            if(response == "1")
            {
                string decription = "This activity will help you relax by walking your through breathing in and out slowy. Clear your mind and focus on your breathing."; 
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity",decription,50);
                activity1.Run();
            }
            else if(response == "2")
            {
                string decription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognise the power you have and how you can use it in other aspects of life.";
                ReflectingActivity activity1 = new ReflectingActivity("Breathing Activity",decription,50);
                activity1.Run();
            }
            else if(response == "3")
            {
                string decription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area?";
                ListingActivity activity1 = new ListingActivity("Breathing Activity",decription,50);
                activity1.Run();
            }
        }
    }
}
