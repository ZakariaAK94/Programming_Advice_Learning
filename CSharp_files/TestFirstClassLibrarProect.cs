using System;
using MyFirstClassLibrary;

internal class Program
{
    static void Main(string[] args)
    {
        ClsMyMath myMath1 = new ClsMyMath();
        Console.WriteLine(myMath1.Sum(10, 59));
        Console.WriteLine(myMath1.Sum(109, 59));

        Console.ReadKey();
        
    }
}

