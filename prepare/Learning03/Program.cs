using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction solver  = new Fraction();
        // solver.SetTop(5);
        // Console.WriteLine(solver.GetTop());
        // solver.SetBottom(7);
        // Console.WriteLine(solver.GetBottom());
        Console.WriteLine(solver.GetFunctionString());
        Console.WriteLine(solver.GetFractionValue());

        Fraction solver2 = new Fraction(2);
        Console.WriteLine(solver2.GetFunctionString());
        Console.WriteLine(solver2.GetFractionValue());
        
        Fraction solver3 = new Fraction(3, 8);
        Console.WriteLine(solver3.GetFunctionString());
        Console.WriteLine(solver3.GetFractionValue());

        Fraction solver4 = new Fraction(7, 10);
        Console.WriteLine(solver4.GetFunctionString());
        Console.WriteLine(solver4.GetFractionValue());
        
        
    }
}