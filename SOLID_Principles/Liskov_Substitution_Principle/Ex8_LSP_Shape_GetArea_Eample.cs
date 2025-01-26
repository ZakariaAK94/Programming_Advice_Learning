using System;


public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Raduis { get; set; }

    public Circle(double raduis)
    {
        this.Raduis = raduis;
    }
    public override double GetArea() => Math.PI*Raduis*Raduis;
}
public class Rectangle : Shape
{
    public double width { get; set; }
    public double height { get; set; }

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea() => width * height;
    
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(4, 8);
        Console.WriteLine("the area of the rectangle is {0}:", rectangle.GetArea());

        Circle circle = new Circle(5);      
        Console.WriteLine("the area of the circle is {0}:", Math.Round(circle.GetArea()*100)/100);

        Console.Read();
    }
}
