using System;

namespace TimeSpanCsharpPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(2023, 2, 21);

            //// Hours, Minutes, Seconds
            //TimeSpan ts = new TimeSpan(49, 25, 34);
            //Console.WriteLine(ts);
            //Console.WriteLine(ts.Days);
            //Console.WriteLine(ts.Hours);
            //Console.WriteLine(ts.Minutes);
            //Console.WriteLine(ts.Seconds);

            ////this will add time span to the date.
            //DateTime newDate = dt.Add(ts);
            //Console.WriteLine(dt);
            //Console.WriteLine(newDate);

            ////Subtraction of two dates results in TimeSpan
            //DateTime dt1 = new DateTime(2023, 2, 21);

            //DateTime dt2 = new DateTime(2023, 2, 25);
            //TimeSpan result = dt1.Subtract(dt2);
            //  Console.WriteLine(result);

            // The DateTime struct overloads +, -, ==, !=, >, <, <=, >= operators to ease out addition, subtraction, and comparison of dates
            DateTime Dt1 = new DateTime(2015, 12, 20);
            DateTime Dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(Dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(Dt2 - Dt1); //377.05:10:20
            Console.WriteLine(Dt1 == Dt2); //False
            Console.WriteLine(Dt1 != Dt2); //True
            Console.WriteLine(Dt1 > Dt2); //False
            Console.WriteLine(Dt1 < Dt2); //True
            Console.WriteLine(Dt1 >= Dt2); //False
            Console.WriteLine(Dt1 <= Dt2);//True


          






            Console.ReadKey();
        }
    }
}
