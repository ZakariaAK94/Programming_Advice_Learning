using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    static void Main(string[] args)
    {

        //Declare an integer array 
        int[] ints = new int[5];

        string[] names = { "Alice", "Bob", "Charlie" };
       
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        // another example just to practice with random
        Random random = new Random();
        for(int i = 0; i < ints.Length; i++)
        {
            ints[i] = random.Next(1,20);
        }
        Console.WriteLine("Array before sorting:");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Array.Sort(ints);
        Console.WriteLine("\nArray after sorting:");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }

        string[] Students = { "Zakaria", "Amal", "Otmane" };
        int index = Array.IndexOf(Students, "Amal");
        Console.WriteLine("\nindex of the student Amal is :"+index);

        Console.ReadLine();


    }
}

