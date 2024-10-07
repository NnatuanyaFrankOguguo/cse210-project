using System;

class Program
{
    static void Main(string[] args)
    {   
       
        // Console.WriteLine(_verseWord.GetDisplayText());
        // Console.Write("Would you like to enter personal scripture to memorize or be given random inspiring ones");
        // string userAnswer = Console.ReadLine();

        Scripture memorizer = new Scripture();
        int hiddenCount = 0;

        

        while(true) 
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            
            memorizer.HideRandomWords(hiddenCount);
            Console.WriteLine(memorizer.GetDisplayText());

            Console.WriteLine("");
            Console.Write("Press enter to continue or type \"quit\" to exist ");
            string response = Console.ReadLine();

            
            if(string.IsNullOrEmpty(response)){  

                hiddenCount ++;
               if(memorizer.IsCompletelyHidden())
                {
                    Console.WriteLine("Congrats you have made it to the end");
                    break;
                }   
                
            }

            else if(response == "quit")
            {
                break;
            }

            
        }
        
    

    }
}