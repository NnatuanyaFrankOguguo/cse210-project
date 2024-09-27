using System;

class Program
{
    static void Main(string[] args)

    {
        //adding the creation of the Promptgenerator and the population of its promptList outside the loop,
        //so that the promptList is initialized only once, and the same Promptgenerator instance is used across multiple iterations of the loop.
        Journal myJournal = new Journal();
        //addid the journal class outside of the loop so that it holds entries across multiple iterations. Otherwise, you'd lose all previously added entries every time the loop restarts.
        Promptgenerator myPromptgenerator = new Promptgenerator();
        myPromptgenerator._promptLists.Add("What is that one life principle i learnt or undestand today?");
        myPromptgenerator._promptLists.Add( "If i had one thing i could do over today, what would it be?");
        myPromptgenerator._promptLists.Add("What was the strongest emotion i felt today?");
        myPromptgenerator._promptLists.Add("How did i see the hand of the Lord in my life today?");
        myPromptgenerator._promptLists.Add("What was the best part of my day?");
        myPromptgenerator._promptLists.Add("What can you say you are satisfied with today?");
        myPromptgenerator._promptLists.Add("Who was the most interesting person i interacted with today?");
    
        while(true)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Journal program!!");
            Console.WriteLine("Please Select the following options. based on the index");
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display ");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");
            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            Console.WriteLine("");
            

            if (response == "1")
            {
               
                DateTime currentTime = DateTime.Now;

                Entry prompt1 = new Entry();
                prompt1._promptText = myPromptgenerator.GetRandomPrompt();
                Console.Write(prompt1._promptText);
                prompt1._entryText = Console.ReadLine();
                prompt1._date = currentTime.ToShortDateString();
                Console.WriteLine("");
                // Add the entry to the journal
                myJournal.AddEntry(prompt1);

            }

            else if(response == "2")
            {
                Console.WriteLine("");
                myJournal.DisplayAll();
            }

            else if( response == "3")
            {
                Console.Write("Enter your journal filename: ");
                string fileName = Console.ReadLine();
                string name = fileName + ".csv";
                myJournal.LoadFromFile(name);
                Console.WriteLine($"{fileName} Loaded Successfully");
                
            }

            else if(response == "4")
            {
                
                while(true)
                {
                    Console.Write("Do you wish to create a new file or add to an existing one. \"yes(create) or no(add)\" ");
                    string userAnswer = Console.ReadLine();
                    if(userAnswer == "yes")
                    {
                        Console.Write("Enter the filename you wish to save your journal: ");
                        string fileName = Console.ReadLine();
                        string name = fileName + ".csv";
                        myJournal.SaveToCsv(name);
                        Console.WriteLine("...");
                        Console.WriteLine($"{fileName} saved Successfully");
                        break;
                    }
                    else if (userAnswer == "no")
                    {
                        Console.Write("Enter the existed filename you wish to save it to: ");
                        string fileName = Console.ReadLine();
                        string name = fileName + ".csv";
                        myJournal.Save(name);
                        Console.WriteLine("...");
                        Console.WriteLine($"Your entries has been saved to your {fileName} Successfully");
                        break;
                    }
                    else{
                        Console.WriteLine("Incorrect input please try again: enter either \"yes or no \" ");
                    }
                }
                
                
                
            }

            else if(response == "5")
            {
                break;
            }

            else{
                Console.WriteLine("Incorrect input: please input an index figure from the options below");
            }

        } 
        
    }
}