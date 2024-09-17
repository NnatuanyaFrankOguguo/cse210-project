using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        int lastDigit = grade % 10;

        if (grade >= 90)
        {   
            if (lastDigit >= 7)
            {
                Console.WriteLine($"A {grade}");
            }
            else
            {
                Console.WriteLine($"A- {grade}");
            }
            
        }

        else if (grade >= 80)
        {
            if (lastDigit >= 7)
            {
                Console.WriteLine($"B+ {grade}");
            }
            else
            {
                Console.WriteLine($"B- {grade}");
            }
        } 

        else if (grade >= 70)
        {
           if (lastDigit >= 7)
            {
                Console.WriteLine($"C+ {grade}");
            }
            else
            {
                Console.WriteLine($"C- {grade}");
            }
        }

        else if (grade >= 60)
        {
           if (lastDigit >= 7)
            {
                Console.WriteLine($"D+ {grade}");
            }
            else
            {
                Console.WriteLine($"D- {grade}");
            }
        } 

        else if(grade < 60)
        {
            Console.WriteLine($"F {grade}");
        }
        
        else
        {
            Console.WriteLine("Invalid Input, Please Try Again");
        }

        if (grade < 70)
        {
            Console.WriteLine("Your grade is pretty poor, we trust you can do better next time");
        }
        else{
            Console.WriteLine("Congratulations on Your Success, Keep it Up");
        }
    }
}