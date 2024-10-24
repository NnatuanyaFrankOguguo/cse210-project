using System;
using System.Security.Cryptography;

public class Circle : Shapes
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14159 * _radius * _radius;
    }


}