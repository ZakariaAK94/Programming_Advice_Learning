using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughAListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Looping through the list using method 1 :\n");
            for(int i=0; i<numbers.Count; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine("Looping through the list using method 2 :\n");
            foreach(int i in numbers) 
                Console.WriteLine(i);

            Console.WriteLine("Looping through the list using method 3 :\n");
            numbers.ForEach(x => Console.WriteLine(x));

            Console.ReadLine();



        }
    }
}
