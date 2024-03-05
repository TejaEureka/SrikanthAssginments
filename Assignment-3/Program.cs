// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main()
    {
        Circle circle = new Circle(7.0);
        Rectangle rectangle = new Rectangle(9.0, 7.0);

        circle.CalculateArea();
        rectangle.CalculateArea();
    }
}
