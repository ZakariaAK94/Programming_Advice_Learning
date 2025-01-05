using System;

namespace StaticPropertiesAndStaticClass
{
    static class Settings
    {
        public static int DayNumber
        {
            get 
            { 
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get 
            { 
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }
    }

    public static class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of the day is: {0} ", Settings.DayNumber);
            Console.WriteLine("Name of the day is: {0} ", Settings.DayName);
            Settings.ProjectPath = @"B:\Downloads.";
            Console.WriteLine("The path is : {0} ", Settings.ProjectPath);
            Console.WriteLine("The same of 157 + 578 = {0} ", MathUtils.Add(157, 578));
            Console.WriteLine("The square  of 64 is {0} ", MathUtils.SquareRoot(64));

                

            Console.ReadLine();


        }
    }
}
