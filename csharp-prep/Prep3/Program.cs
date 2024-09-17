using System;

class Program
{
    static void Main(string[] args)
    {
        // int magicNumber = 10; 
        // Console.Write("What is the magic number? ");
        string response = " ";

        while (response != "no")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int number = 0;
            int guesses = 0;

            while (magicNumber != number)
            {
                Console.Write("What is your guess? ");
                number = int.Parse(Console.ReadLine());
                guesses++ ;

                if (number > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (number < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it, right!");
                    Console.WriteLine($"it took you this number of {guesses}");
                }
            }

            Console.Write("Do you want to try again? 'yes' or 'no': ");
            response = Console.ReadLine();

        }

    }
}