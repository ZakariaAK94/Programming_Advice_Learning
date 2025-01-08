using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateWithExample
{
    internal class Program
    {
        // public delegate bool Predicate<in T>(T obj);
        static bool IsEven(int number) => (number % 2 ==0);
        static bool CheckIfDivideByThree(int number) => (number % 3 == 0);
        static bool CheckIfDivideByFive(int number) => (number % 5 == 0);

        static void CheckNumbers(List<int> Numbers, Predicate<int> Predicate)
        {            
            foreach (int number in Numbers)
            {
                if (Predicate(number))
                    Console.Write(number + " ");
            }
         
        }

        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> { 15, 17, 21, 9, 5, 36, 87, 9, 46, 27, 38 };

            Console.WriteLine("The original list is : ");
            foreach (int number in Numbers)
                Console.Write(number+" ");
            Console.WriteLine("\n\nthe result for even numbers is the next list :");
            CheckNumbers(Numbers, IsEven);

            Console.WriteLine("\n\nthe result for numbers that divide by three is the next list :");
            CheckNumbers(Numbers,CheckIfDivideByThree);
            
            Console.WriteLine("\n\nthe result for numbers that divide by five is the next list :");
            
            CheckNumbers(Numbers,CheckIfDivideByFive);

            Console.ReadLine();
        }


    }
}

