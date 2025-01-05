using System;

namespace CSharpMathExamplesPRAdvice
{
    internal class Program
    {
        int MaxOfValue(int X, int Y)
        {
            return (X < Y) ? Y : X;
        }

        static void PrintInfo(string FirstName,int Age, string LastName = "It is optional")
        {
            Console.WriteLine("FirstName = {0}, LastName ={1} and Your Age = {2}.",FirstName,LastName,Age);
        }

        static void PrintInfo(string FirstName, string LastName = "It is optional")
        {
            Console.WriteLine("FirstName = {0}, LastName ={1}", FirstName, LastName);
        }
        static void PrintInfo(int Age)
        {
            Console.WriteLine("Your Age = {0}.",Age);
        }

        static void PrintMyName()
        {
            Console.WriteLine("Mohammed Abu-Hadhoud");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5, 10));
            Console.WriteLine("Square Root of 64 is: {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is: {0}", Math.Round(9.99));

            Program Obj1 = new Program();
            Console.WriteLine("the max of 10 and 56 is "+Obj1.MaxOfValue(10, 56));

            PrintInfo("Zakaria", 26);
            PrintInfo("Zakaria", 26,"AKIL");
            PrintInfo(Age:27,FirstName:"Zakaria",LastName:"AKIL");
            PrintInfo(FirstName:"Zakaria",LastName:"AKIL");
            PrintInfo(Age:27);

            PrintMyName();

            Console.ReadKey();
        }
    }
}
