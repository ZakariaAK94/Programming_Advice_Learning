using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassCSharp
{
    public class OuterClass
    {
        private int OuterVariable;

        public OuterClass(int Outer)
        {
            this.OuterVariable = Outer;
        }

        public void OuterMethod()
        {
            Console.WriteLine("OuterMethod is called.");
        }

        public class InnerClass
        {
            private int InnerVariable;

            public InnerClass(int Inner)
            {
                this.InnerVariable = Inner;
            }
            public void InnerMethod()
            {
                Console.WriteLine("InnerMethod is called wiht InnerVariable = "+InnerVariable);
            }

            public void AccessOuterVariable(OuterClass outer)
            {
                Console.WriteLine("Access variable of OuterClass from InnerClass " + outer.OuterVariable);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // create an instance of OuterClass
            OuterClass Outer1 = new OuterClass(100);
            // create an instance of InnerClass
            OuterClass.InnerClass Inner1 = new OuterClass.InnerClass(40);
            // call methods on the instances
            Outer1.OuterMethod();
            Inner1.InnerMethod();
            Inner1.AccessOuterVariable(Outer1);

            Console.ReadKey();
        }
    }
}
