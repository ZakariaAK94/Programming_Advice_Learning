using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInCSharpPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// declaraton Array of one dimension
            //int[] x = new int[3] {2,5,6};
            //int[,] numbers= new int[2, 3] { { 1, 5, 9 },{ 8, 7, 4 }};

            //// access first element from the first row
            //Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            //// access first element from second row
            //Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

            //foreach(int i in numbers)
            //    Console.WriteLine("Element in the table : " + i);

            char[] Greetings = { 'H', 'e', 'l', 'l', 'o' };

            foreach(char c in Greetings)
                Console.Write(c);

            char[] gender = { 'm', 'f', 'f', 'f', 'm','m','m' };
            byte male = 0;
            byte female = 0;
            foreach(char g in gender)
            {
                if(g=='m')
                    male++;
                else if(g=='f')
                    female++;
            }

            Console.WriteLine("\n\nNumber of male is {0} and number of female is {1}.", male, female);

            Console.ReadKey();
        }
    }
}
