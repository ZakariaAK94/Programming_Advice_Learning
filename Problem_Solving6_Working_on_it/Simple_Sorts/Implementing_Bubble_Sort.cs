﻿using System;

class BubbleSortExample
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 10 };

        Console.WriteLine("Original array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        BubbleSort(arr);
        Console.WriteLine("\nInserted array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.ReadKey();
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
       for(int i=0; i<n-1; i++) 
       {
            for(int j=0; j<n-i-1; j++)
            {
                if (arr[j+1] < arr[j])
                    (arr[j], arr[j+1])=(arr[j+1], arr[j]);
            }

       }
    }
}