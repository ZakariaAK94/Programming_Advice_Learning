using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchExample
{

     class Program
    {
        static int LinearSearch(int[] arr, int targetValue)
        { 
            for(int i = 0;i<arr.Length;i++)
            {
                if (arr[i] == targetValue)
                    return i;
            }
            
            
            return -1; 
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int targetvalue = 2;

            int index = LinearSearch(arr, targetvalue);

            Console.WriteLine("the original array is :");

            foreach(int i in arr) Console.Write(i+" ");

            if (index  == -1 )
            {
                Console.WriteLine("\nthe item are you looking for doesn't exist");
            }else
            {
                Console.WriteLine($"\nthe index of the item {targetvalue} is {index}");
            }

            Console.ReadLine();
        }
    }
}
