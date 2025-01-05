using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    internal class Program
    {
        public class Singleton
        {
            private static Singleton instance;

            private Singleton() { }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }    
        public class SomeClass
        {
            private SomeClass() { }

            public static SomeClass CreateInstance()
            {
                // Perform some customization or validation logic here if needed
                return new SomeClass();
            }
        }
       public static class MathUtility
        {
            private MathUtility() { }

            public static int Add(int a, int b)
            {
                return a + b;
            }
        }

        public static class Calculator
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public double Multiply(double a, double b)
            {
                return a * b;
            }
        }

        public sealed class FinalClass
        {
            // Members and methods
        }
       

        static void Main(string[] args)
        {
        }
    }
}
