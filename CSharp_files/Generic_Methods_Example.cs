using System;
using System.Linq;
using System.Reflection;
using System.Xml.Schema;

///<summary>This class represents an example of using a genreic method inside it </summary>
public class Utility
{
    /// <summary>
    /// Swap is a method that changes values of two parameters
    /// </summary>
    /// <typeparam name="T"> T must be replaced with the datatype suitable to your code</typeparam>
    /// <param name="First">this is the first paramter, must be pass by reference </param>
    /// <param name="Second">this is the second paramter, must be pass by reference</param>
    /// <returns></returns>
    public static T Swap<T>(ref T First, ref T Second)
    {
        T temp;
        temp = First;
        First = Second;
        Second = temp;
        return temp;
    }

    public static T add<T>(T number1, T number2)
    {
        dynamic a = number1;     //The dynamic type defers type checking until runtime, which means that operations like addition can be performed on any types that support
                                 //the + operator at runtime, even if the compiler doesn't know whether the operation is valid at compile time.
        dynamic b = number2;     //it comes with trade-offs in terms of performance and type safety, so it should be used judiciously.If type safety and performance are critical,
        return (T)(a+b);        // other approaches like method overloading or using delegates may be more appropriate.
    }

    public static T SumElements<T>(T[] Array)
    {
        dynamic sum = default(T);    //Yes, the default keyword in C# is used to initialize a variable to its default value for its type. This default value depends on the type
        foreach (T item in Array)    //of the variable:
            sum += item;             //For numeric types(e.g., int, double), the default value is 0.
                                     //For bool, the default value is false.
        return (T)(sum);             //For reference types(e.g., string, classes), the default value is null.
                                     //For char, the default value is \0(the null character).
                                     //For structs, it initializes all the fields to their default values.        
    }

    


}

 class Program
{
    static string GetParamterList(ParameterInfo[] parameters)
    {
        return string.Join(",", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
    }
    static void Main()
    {

        Type myclsTest = typeof(Utility);

        //Console.WriteLine($"Type Full Name : {myclsTest.FullName}");
        //Console.WriteLine($"Type Name : {myclsTest.Name}");

        //foreach (var method in myclsTest.GetMethods())
        //{
        //    Console.WriteLine($"\t{method.ReturnType}  {method.Name}({GetParamterList(method.GetParameters())})");
        //}

        //int a = 4, b = 20;
        //Console.WriteLine($"Before Swap : a ={a} and b={b}");   
        //Utility.Swap(ref a, ref b );
        //Console.WriteLine($"After Swap : a ={a} and b={b}");
        //Console.WriteLine();
        //string n1 = "Zakaria", n2 = "Ahmed";
        //Console.WriteLine($"Before Swap : a ={n1} and b={n2}");
        //Utility.Swap(ref a, ref b);
        //Console.WriteLine($"After Swap : a ={n2} and b={n2}");


        //int a1 = 4, b1 = 20;
        //int result = Utility.add(a1, b1);
        //Console.WriteLine($"The addition bewteen {a1} and {b1} is {result}");
        //Console.WriteLine();
        //string n3 = "Zakaria", n4 = " Ahmed";
        //string result1 = Utility.add(n3,n4);
        //Console.WriteLine($"The concatination between {n3} and {n4} is :{result1} ");

        int[] Array1 = { 1, 2, 3, 4, 5, 6, 7, 8};
        Console.WriteLine($"The sum of the array provided is : {Utility.SumElements(Array1)} ");

        string[] words = { "Hello", " ", "World", "!" };
        Console.WriteLine($"The concatination of the array provided is : {Utility.SumElements(words)} ");

        Console.ReadLine(); 




    }
}

