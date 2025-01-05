using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatingDataUsingLINQwithList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("the sum of elements in ints is : "+ints.Sum());
            Console.WriteLine("the average of elements in ints is : "+ints.Average());
            Console.WriteLine("the min of elements in ints is : "+ints.Min());
            Console.WriteLine("the max of elements in ints is : "+ints.Max());
            Console.WriteLine("the number of elements in ints is : "+ints.Count());

            Console.ReadKey();
        }
    }
}
