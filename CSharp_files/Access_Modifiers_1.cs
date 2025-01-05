using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers1
{
    class clsA
    {
        public int x1= 10;
        private int x2= 20;
        protected int x3= 30;

        public int funct1()
        {
            return 100;
        }

        private int funct2()
        {
            return 200;
        }

        protected int funct3()
        {
            return 300;
        }
    }

    class clsB : clsA
    { 
        public int funct4()
        {
            // we can acces to x1 public and x3 protected, but we can not acces to x2 private in the base class
            return x1+ x3;  
        }
    
    
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            clsA A1 = new clsA();
            Console.WriteLine(A1. funct1());
            Console.WriteLine(A1. x1);
            clsB B1 = new clsB();
            Console.WriteLine(B1. funct1());
            Console.WriteLine(B1.funct4());
            Console.ReadLine();
        }
    }
}
