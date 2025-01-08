using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TuplesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Tuple Classes(Prior to C# 7.0):
            Tuple<int, string, bool> myTuple = new Tuple<int, string,bool>(1, "Hello", true);
            //Using ValueTuple(C# 7.0 and later):
            (int Id, string Name, bool isActive) myTuple2 = (1, "Ziko", false);

            Console.WriteLine($"Content of myTuple2 is : {myTuple2.Id}, {myTuple2.Name}, {myTuple2.isActive}");

            var myTuple3 = GetInfo();
            Console.WriteLine($"Content of myTuple3 is : {myTuple3.Item1}, {myTuple3.Item2}");

            Console.ReadLine();
        }

        static (int,string) GetInfo()
        {
            return (20, "Nadir");
        }
    }
}
