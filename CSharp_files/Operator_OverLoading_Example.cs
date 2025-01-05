using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    
   
    /// <summary>
    /// this is a class with overloading of operators like +,-,==,!= and tostring()
    /// </summary>
    public class Point
    {
        public int X;
        public int Y;


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }
        public static bool operator ==(Point a, Point b)
        {
            return (a.X == b.X) && (a.Y == b.Y);
        }
        public static bool operator !=(Point a, Point b)
        {
            return (a.X != b.X) || (a.Y != b.Y);
        }

        public string ToString()
        {
            return $"({this.X},{this.Y})";
        }
    }
    static void Main(string[] args)
    {

       
        Point P1 = new Point(5, 9);
        Point P2 = new Point(3, 7);
        Console.WriteLine($"the point P1 has: X = {P1.X} and Y = {P1.Y}");
        Console.WriteLine($"the point P2 has: X = {P2.X} and Y = {P2.Y}");
        Point P3 = P1 + P2;
        Console.WriteLine($"the  P1 + P2 give the result P3: X = {P3.X} and Y = {P3.Y}");
        P3 = P1 - P2;
        Console.WriteLine("the  P1 - P2 give the result P3: X" + P3.ToString());
        if (P1 == P2)
            Console.WriteLine($"Yes,P1 and P2 are egal");
        else
            Console.WriteLine($"Non,P1 and P2 are egal");


        Console.ReadKey();


    }
}

