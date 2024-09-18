using System;


class Program

{
    static void Main(string[] args)
    {
        int input = -1000000000;
        Console.WriteLine("Enter a list of number, type 0 when finished."); 
        List<int> numbers = new List<int>();
        while (input != 0)
        {
            Console.Write("Enter Number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);               
        }
        numbers.Remove(0);
        float totalSum = numbers.Sum();
        int totalCount = numbers.Count();
        float average = totalSum / totalCount;
        int largestDigit = numbers.Max();
        int smallestDigit = numbers.Where(num => num > 0).Min();
        numbers.Sort();
        Console.WriteLine($"The totalCount is: {totalCount}");
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The largest is : {largestDigit}");
        Console.WriteLine($"The smallest positive is : {smallestDigit}");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}