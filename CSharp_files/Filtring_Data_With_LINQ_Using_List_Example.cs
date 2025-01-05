using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringDataWithLINQinCSharpUsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("EvenNumbers in ints list : " +string.Join(",",ints.Where(n => n%2==0)));
            Console.WriteLine("OddNumbers in ints list : " + string.Join(",", ints.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers greather than 3 and smaller than 9 : " + string.Join(",", ints.Where(n => n>3 && n<9)));
            Console.WriteLine("Display numbers where its index multiple of 2 : " + string.Join(",", ints.Where((_,index) => index%2==0)));
            Console.WriteLine("Display numbers where its index multiple of 3 : " + string.Join(",", ints.Where((_,index) => index%3==0)));
            Console.ReadLine();

        }
    }
}
