using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExampleCSharp
{
    class clsA
    {
        public int x;
        public int y;

        public void Method1()
        {
            Console.WriteLine("Method1 of class A is called");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 of class A is called");
            Console.WriteLine("Now I will call Method1 from Class B");

            clsB B1 = new clsB();
            B1.Method1();
        }
    }

    public class clsB
    {
        public virtual void Method1()
        {
            Console.WriteLine("Method1 called from class B");
        }
    }

    public class clsC : clsB
    {
        public sealed override void Method1()
        {
            Console.WriteLine("Method1 called from class C");
        }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();

            A.Method1();
            A.Method2();

            Console.ReadKey();

        }
    }
}
