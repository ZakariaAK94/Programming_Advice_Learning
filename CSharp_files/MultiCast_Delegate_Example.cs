using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_delegate
{
    class Program
    {
        static void Main()
        {
           Action<string> myDelegate = Method1;
            myDelegate += Method2;
            myDelegate += Method3;

            myDelegate("Hello, world!");

            myDelegate -= Method1;
            Console.WriteLine("---------------------------------------");
            myDelegate("Another message.");

            Console.ReadLine();
        }


        static void Method1(string message)
        {
            Console.WriteLine("Method1: " + message);
        }


        static void Method2(string message)
        {
            Console.WriteLine("Method2: " + message);
        }

        static void Method3(string message)
        {
            Console.WriteLine("Method3: " + message);
        }


    }
}

