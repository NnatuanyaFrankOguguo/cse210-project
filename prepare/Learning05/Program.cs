using System;

class Program
{
    static void Main(string[] args)
    {   
        Math math = new Math("Frank Oguguo", "Fractions", "Section 7.3", "Problem 8-19");
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine("");

        Writing writing = new Writing("Mary Stone", "European History", "The Cause of the World War II by Mary Stone");
        Console.WriteLine(writing.GetWritingInformation());
    }

}