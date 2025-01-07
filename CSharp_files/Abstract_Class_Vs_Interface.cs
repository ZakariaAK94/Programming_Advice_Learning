using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AbstractClassVsInterface
{
     class Program
    {
        interface IShape
        {
            void Draw();// abstract method : must be implemented in the derived classes
            double GetArea();
        }

        interface IColor
        {
            string GetColor();
        }

        class Circle : IShape, IColor
        {
            public double Raduis { get; set; }

            public Circle(double radius)
            {
                this.Raduis = radius;
            }

            public double GetArea()
            {
                return Math.Round(Math.PI * Raduis * Raduis, 2);
            }

            public string GetColor()
            {
                return "Red";
            }
            public void Draw()
            {
                Console.WriteLine("the area of your circle is {0}, the color chosen is {1}",GetArea(),GetColor());
            }

        }

        class Rectangle : IShape, IColor
        {
            public double width { get; set; }
            public double height { get; set; }
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double GetArea()
            {
                return Math.Round(width * height, 2);
            }
            public string GetColor()
            {
                return "Yellow";
            }
            public void Draw()
            {
                
                Console.WriteLine("the area of your rectangle is {0}, the color chosen is {1}", GetArea(), GetColor());
            }
        }

        class Square : IShape
        {
            public double width { get; set; }
            public Square(double width)
            {
                this.width = width;
            }

            public double GetArea()
            {
                return Math.Round(width * width, 2);
            }

            public void Draw()
            {
                Console.WriteLine("The area of your square is {0}", GetArea());
            }
        }      

        /*********************/

        abstract class Shape
        {
            public abstract double GetArea();
            public abstract void Draw();
        }

        // abstract class supports single inheritance, so Trapezoid won't be able to inherite class Color
        abstract class Color
        {
            public abstract string GetColor();
        }
        // i will use only one example to make the code clean

        class Trapezoid : Shape
        {
            public double smallwidth { get; set; }
            public double bigwidth { get; set; }
            public double height { get; set; }
            public Trapezoid(double smallwidth, double bigwidth, double height)
            {
                this.smallwidth = smallwidth;
                this.bigwidth = bigwidth;
                this.height = height;
            }

            public override double GetArea()
            {
                return Math.Round(0.5 * (smallwidth + bigwidth) * height, 2);
            }

            public override void Draw()
            {
                Console.WriteLine("The area of your trapezoid is {0}", GetArea());
            }
        }

        class Triangle : Shape
        {
            public double width { get; set; }
            public double height { get; set; }
            public Triangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public override double GetArea()
            {
                return Math.Round(0.5 * width * height, 2);
            }

            public override void Draw()
            {
                Console.WriteLine("The area of your triangle is {0}", GetArea());
            }
        }
        static void Main(string[] args)
        {
            List<IShape> Shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(7,2),
                new Square(6)
            };

            foreach(var shape in Shapes)
                 shape.Draw();

            List<Shape> shapes = new List<Shape>
            {
                new Trapezoid(2,4,3),
                new Triangle(5,3) 
            };

            foreach(var shape in shapes)
                shape.Draw();

            Console.ReadKey();
        }
    }
}

//summarize
/*
  - Abstract class:
    supports single inheritance
    Can Have both abstract and concrete methods
    Can have fields and properties
    purpose: shared behavior and partial implementaion
 - Interface
    supports multiple inheritance
    Can Have only abstract methods
    Can have only properties
    purpose: contract definition only 
 
 */