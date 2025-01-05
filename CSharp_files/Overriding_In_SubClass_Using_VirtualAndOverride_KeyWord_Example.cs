using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRidingAndKeyWordBase
{
    public class MyBaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("function1 is called form the base class A");
        }

        public virtual void MyOtherMethod()
        {
            Console.WriteLine("function2 is called form the base class A");
        }

    }

    public class MyDerivedClass : MyBaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("function1 is called from the derived class B by overriding method");
        }

        public new void MyOtherMethod()
        {
            Console.WriteLine("function2 is called from the derived class B by hiding method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass myBaseObj = new MyBaseClass();
            Console.WriteLine("\nBase Object : \n");
            myBaseObj.MyMethod();
            myBaseObj.MyOtherMethod();

            MyDerivedClass myDerivedObj = new MyDerivedClass();
            Console.WriteLine("\nDerived Object: \n");
            myDerivedObj.MyMethod();
            myDerivedObj.MyOtherMethod();

            MyBaseClass myBaseObj1 = new MyDerivedClass();
            Console.WriteLine("\nUpcasting base Object: \n");
            myBaseObj1.MyMethod();
            myBaseObj1.MyOtherMethod();



            Console.ReadKey();
        }
    }
}
