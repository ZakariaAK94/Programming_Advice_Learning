using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingaListinCSharpUsingVariousMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 100, -2,53, 24, -5, 630, 72, -8, 90, -10 };

            Console.WriteLine("Original List: " + string.Join(",", ints));

            ints.Sort();
            Console.WriteLine("List order by ascending: " + string.Join(",", ints));
            ints.Reverse();
            Console.WriteLine("List order by descending: " + string.Join(",", ints));


            Console.WriteLine("List order by ascending: " + string.Join(",", ints.OrderBy(n=>n)));
            Console.WriteLine("List order by descending: " + string.Join(",", ints.OrderByDescending(n=>n)));

            ints.Sort((a, b) => Math.Abs(a).CompareTo(Math.Abs(b)));
            Console.WriteLine("Sorted by Absolute Values: " + string.Join(", ", ints));



            Console.ReadLine();

        }
    }
}
