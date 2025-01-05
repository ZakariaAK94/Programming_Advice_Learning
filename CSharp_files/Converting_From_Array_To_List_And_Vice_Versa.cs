using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingAListToAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] numbersArray = numbers.ToArray();

            Console.WriteLine("Array numbers: "+string.Join("-", numbersArray));

            List<int> numberFromArray = numbersArray.ToList();
            List<int> numberFromArray2 = new List<int> (numbersArray);

            Console.WriteLine("List numbers: " + string.Join("-", numberFromArray));

            Console.ReadKey();
        }
    }
}
