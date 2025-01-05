using System;
using System.Linq;

namespace ArrayOperationsUsingSystemLinqPRAdviceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Marks = { 51, -1, 2, 14, 18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest Element : " + Marks.Min());
            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + Marks.Max());
            // compute Count
            Console.WriteLine("Count : " + Marks.Count());
            // compute Sum
            Console.WriteLine("Sum : " + Marks.Sum());
            // compute the average
            Console.WriteLine("Average: " + Marks.Average());

            Console.ReadKey();
        }
    }
}
