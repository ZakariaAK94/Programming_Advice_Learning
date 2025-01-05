using System;

namespace StaticMembers
{
    class clsA
    {
        public int x1;
        // x2 is shared for all object because it's on class level
        public static int x2;

        public int method1()
        {
            // no static methods can always access the static memebers
            return x1 + x2;
        }

        public static int method2()
        {
            //static method can not access non static members because there is no object
            //static method are called at the class level
            // return clsA.x1 + x2, when you write clsA.x1 ha has to bring which x1 of which object so doesn't work
            return x2;
        }

    }






    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of employee class
            clsA ObjA1 = new clsA();
            clsA ObjA2 = new clsA();

            ObjA1.x1 = 7;
            ObjA2.x1 = 15;

            // x2 is shared for all object because it's on the class level
            // using the class name
            clsA.x2 = 700;

            Console.WriteLine("objA1.x1 = {0}", ObjA1.x1);
            Console.WriteLine("objA2.x1 = {0}", ObjA2.x1);
            Console.WriteLine("objA1.method1 results: = {0}", ObjA1.method1());
            Console.WriteLine("objA2.method1 results: = {0}", ObjA2.method1());

            // method2 can not be accessed through object, only through the class itself
            // Console.WriteLine(objA1.method2());
            Console.WriteLine("static method2 results :={0}",clsA.method2());
            Console.WriteLine("static x2: ={0}", clsA.x2);

            Console.ReadLine();





        }
    }
}
