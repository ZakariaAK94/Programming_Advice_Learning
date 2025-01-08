using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstReflectionSpace
{
    public class clsTest
    {
        public static int Property1 { get; set; }
        public static int Property2 { get; set; }
        public int Property3
        { 
            get
            { return Property1 * Property2; }
        }

        public static int AddCalculator(int x,int y)
        {
            return x+y;
        }
        // we can write: Action Method1() => Console.WriteLine("\tMethod1 is Executed");
        public void PrintMessage()
        {
            Console.WriteLine($"\tSum of {Property1} and {Property2} is : {AddCalculator(Property1, Property2)}");
        }
       // public static Action PrintMessage() => { Console.WriteLine($"\tSum of {Property1} and {Property2} is : {AddCalculator(Property1, Property2)}");}
    }
    class Program
    {
        static string  GetParamterList(ParameterInfo[] parameters)
        {
            return string.Join(",",parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }

        static void Main()
        {
            Type myclsTest = typeof(clsTest);

            // Get and display information about the type
            Console.WriteLine($"Type Name: {myclsTest.Name}");
            Console.WriteLine($"Full Name: {myclsTest.FullName}");
            // Get the properties of MyClass
            Console.WriteLine("\nProperties:");
            foreach(var property in myclsTest.GetProperties())
            {
                Console.WriteLine($"Property Name {property.Name} and Type {property.PropertyType}");
            }
            Console.WriteLine("\nMethods:\n");
            foreach (var method in myclsTest.GetMethods())
            {
                Console.WriteLine($"\t{method.ReturnType}  {method.Name}({GetParamterList(method.GetParameters())})");
            }
            //Create an instance of MyClass
            object myclsInstance = Activator.CreateInstance(myclsTest);

            // Set the value of Property1 using reflection
            myclsTest.GetProperty("Property1").SetValue(myclsInstance, 42);
            myclsTest.GetProperty("Property2").SetValue(myclsInstance, 82);
            Console.WriteLine("\nSet Property1 to 42 using reflection:");
            Console.WriteLine("\nSet Property2 to 82 using reflection:");

            // Get the value of Property1 using reflection
            Console.WriteLine("\nGetting Property1's value using reflection:");
            int Property1Value = (int)myclsTest.GetProperty("Property1").GetValue(myclsInstance);
            Console.WriteLine($"\tProperty1 Value: {Property1Value}");
            Console.WriteLine("\nGetting Property2's value using reflection:");
            int Property2Value = (int)myclsTest.GetProperty("Property2").GetValue(myclsInstance);
            Console.WriteLine($"\tProperty2 Value: {Property2Value}");
            Console.WriteLine("\nGetting Property3's value using reflection:");
            int Property3Value = (int)myclsTest.GetProperty("Property3").GetValue(myclsInstance);
            Console.WriteLine($"\tProperty3 Value: {Property3Value}");

            //now how to execute methods using reflection:
            Console.WriteLine("\nExecuting Methods using reflection:\n");
            myclsTest.GetMethod("PrintMessage").Invoke(myclsInstance, null);

            Console.ReadLine();


        }
    }
}
