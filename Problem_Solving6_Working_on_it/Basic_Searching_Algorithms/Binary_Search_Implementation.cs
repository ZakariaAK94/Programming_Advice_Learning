using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


 class BinarySearchImplementation
{
        static int BinarySearch(int[] arr, int targetValue)
        {
            int start = 0, end = arr.Length-1;

            int middle;

           while(start <= end)
           {
                middle = start + (end-start)/2;
            if (arr[middle] == targetValue)
                return middle;

            if (arr[middle] > targetValue )
                end = middle-1;

            if (arr[middle] < targetValue )
                start = middle+1;
           
           }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 37, 41, 45,46, 49, 51,55,58,70,80,82,90,95 }; // Sorted array

             int x = 45; // Element to be searched

            Console.WriteLine("Sorted Array:");
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            int result = BinarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + result);

            Console.ReadLine();
        }
}

