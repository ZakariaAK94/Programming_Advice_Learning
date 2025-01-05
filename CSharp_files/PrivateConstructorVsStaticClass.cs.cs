using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructorVsStaticClass
{
    public class MyStaticClass
    {
        // Static method of the static class
        public static void DoSomething()
        {
            Console.WriteLine("Static method called.");
        }

        // Private constructor prevents instantiation
        private MyStaticClass()
        {
            // Constructor logic, if needed
        }

        
    }

    public static class MathUtility
    {
        // Static method to calculate the square of a number.
        public static double Square(double number)
        {
            return number * number;
        }

        public static int Square(int number)
        {
            return number * number;
        }

        // Static method to calculate the factorial of a number.
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (n == 0)
            {
                return 1;
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            // You cannot create an instance of a static class,
            // and the private constructor is not accessible.
            // MyStaticClass instance = new MyStaticClass(); // This will result in a compilation error.

            // You can call static methods directly from the class.
            MyStaticClass.DoSomething();

            double num = 5.0;
            double squared = MathUtility.Square(num);
            Console.WriteLine($"The square of {num} is {squared}");

            int factorialNumber = 4;
            int factorialResult = MathUtility.Factorial(factorialNumber);
            Console.WriteLine($"The factorial of {factorialNumber} is {factorialResult}");

            Console.ReadKey();
        }
    }
}
