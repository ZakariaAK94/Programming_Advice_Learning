using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnotherExampleOfUsingReflection
{
    internal class Program
    {
        static void Main()
        {
            // Get the MethodInfo object for ExampleMethod
            MethodInfo methodInfo = typeof(Program).GetMethod("ExampleMethod");
            // Get the parameters of ExampleMethod
            ParameterInfo[] parameters = methodInfo.GetParameters();

            // Use the GetParameterList method to get a formatted string of parameters
            string parameterlist = GetParameterList(parameters);
            // Get the return type of the method
            string returntype = methodInfo.ReturnType.ToString();
            // Display the method signature with return type and parameters
            Console.WriteLine($"{returntype}"); 
            Console.WriteLine($"{methodInfo}"); 
            Console.WriteLine($"{parameterlist}"); 

            Console.ReadLine();
        }
        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(",",parameters.Select(p => $"{p.ParameterType} {p.Name}"));
        }
        public void ExampleMethod(int x, string name, decimal salary) 
        {
            Console.WriteLine("Hello World!");
        }
    }
}
