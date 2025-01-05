using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeDataExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings (string): string in C# is a reference type, but it behaves in some ways like a value type
            //due to its immutability. Once a string is created,
            //its value cannot be changed. If you "modify" a string, a new string object is created in memory.
            string s1 = "Hello";
            string s2 = s1; // s2 references the same string as s1
            s2 = "World";   // s2 now points to a new string object, but s1 remains "Hello"

            Console.WriteLine($"S1 is {s1} and S2 is {s2}");

            Console.ReadLine();
        }
    }
}
