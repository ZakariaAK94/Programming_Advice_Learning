using System;

public class Rectangle
{
    public virtual int width { get; set; }
    public virtual int height { get; set; }

    public int GetArea() => width * height;

}

public class Square : Rectangle
{
    public override int width 
    {
        get => base.width; 
        set => base.width = base.height= value; 
    }

    public override int height
    {
        get => base.height;
        set => base.width = base.height = value;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle {width = 4, height= 8 };
        Console.WriteLine("the area of the rectangle is {0}:", rectangle.GetArea());

        Square square = new Square { width = 5 };      
        Console.WriteLine("the area of the square is {0}:", square.GetArea());

        Console.Read();
    }
}
