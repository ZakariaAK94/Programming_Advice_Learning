using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            object y = x; // boxing
            int z = (int)y; // unboxing

            Console.ReadKey();
        }
    }
}
