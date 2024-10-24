using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();
        Square square1 = new Square(53.4, "blue");
        Rectangle rectangle1 = new Rectangle(33.5,22.44, "red");
        Circle circle1 = new Circle(33.5, "yellow");
        shapes.Add(circle1);
        shapes.Add(square1);
        shapes.Add(rectangle1);

        foreach (Shapes shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The {color} shape has an area of {area}");
            Console.WriteLine("");
        }
    }
}