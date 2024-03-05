using System;

class Shape
{
    public virtual double CalculateArea()
    {
        return 0.0;
    }

    public void PrintAreaDetails()
    {
        //Console.WriteLine($"Shape Type: ");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        Console.WriteLine("The value is " +  Radius);
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine("The value is " + Radius);
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

