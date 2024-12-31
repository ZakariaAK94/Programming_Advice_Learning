using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRidingAndKeyWordBase
{
    public class clsA
    {
        public virtual void print()
        {
            Console.WriteLine("this function is called form the base class A");
        }
    }    

    public class clsB : clsA
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("this function is called from the derived class B");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsB B = new clsB();
            B.print();
            Console.ReadKey();
        }
    }
}
