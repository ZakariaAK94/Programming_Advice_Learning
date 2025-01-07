using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        // Array numbers
        int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8 };

        var EvenNbrs = ints.Where(x=> x % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach(int i in EvenNbrs)
        {
            Console.WriteLine(i+"\t");
        }

        int sumEvenNbrs = EvenNbrs.Sum();

        Console.WriteLine($"the sum of even numbers :{sumEvenNbrs}");

        Console.ReadLine();
    }
}

