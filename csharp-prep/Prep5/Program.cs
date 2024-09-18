using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = UserName();
        int number = FavNumber();
        int squareNumber  = SquareNumber(number);
        DisplayResult(name,  squareNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;    
    }

    static int FavNumber()
    {
        Console.Write("What is your favorite number ");
        int fav = int.Parse(Console.ReadLine());
        return fav; 
    }

    static int SquareNumber(int fav)
    {
        int square = fav * fav;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }    
    
    
}