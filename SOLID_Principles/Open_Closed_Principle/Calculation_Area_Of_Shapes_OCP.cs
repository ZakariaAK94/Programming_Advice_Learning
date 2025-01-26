using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

public class CalculationService
{
    private ICalculateArea _calculateArea;
    public CalculationService(ICalculateArea calculateArea)
    {
        _calculateArea = calculateArea;
    }
    public void Draw() => _calculateArea.Draw();
}

public interface ICalculateArea
{
     void Draw();
}


public class Circle : ICalculateArea
{
    private double _Raduis;
    public Circle(double radius)
    {
        _Raduis = radius;
    }

    private double _GetArea() =>  Math.Round(Math.PI * _Raduis * _Raduis, 2);    

    public void Draw() => Console.WriteLine("the area of your Circle is {0}", _GetArea());
    
}

public class Rectangle : ICalculateArea
{
    private double _width;
    private double _height;
    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    private double _GetArea() =>  Math.Round(_width * _height, 2);
    
    public void Draw() => Console.WriteLine("the area of your rectangle is {0}", _GetArea());
    
}

public class Square : ICalculateArea
{
    private double _width { get; set; }
    public Square(double width)
    {
        _width = width;
    }
    private double _GetArea() => Math.Round(_width * _width, 2);
    
    public void Draw() => Console.WriteLine("The area of your square is {0}", _GetArea());
    
}

public class Trapezoid : ICalculateArea
{
    private double _smallwidth { get; set; }
    private double _bigwidth { get; set; }
    private double _height { get; set; }
    public Trapezoid(double smallwidth, double bigwidth, double height)
    {
        _smallwidth = smallwidth;
        _bigwidth = bigwidth;
        _height = height;
    }

    private double _GetArea() => Math.Round(0.5 * (_smallwidth + _bigwidth) * _height, 2);
    

    public void Draw() => Console.WriteLine("The area of your trapezoid is {0}", _GetArea());
    
}

public class Triangle : ICalculateArea
{
    private double _width { get; set; }
    private double _height { get; set; }
    public Triangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    private double _GetArea() => Math.Round(0.5 * _width * _height, 2);    

    public void Draw() => Console.WriteLine("The area of your triangle is {0}", _GetArea());
}
class Program
{       
        static void Main(string[] args)
        {
            List<CalculationService> Shapes = new List<CalculationService>
            {
                new CalculationService(new Circle(5)),
                new CalculationService(new Rectangle(7,2)),
                new CalculationService(new Square(6)),
                new CalculationService(new Trapezoid(2,4,3)),
                new CalculationService(new Triangle(5,3))
            };

            foreach(var shape in Shapes)
                 shape.Draw();

          
            Console.ReadKey();
        }
}


