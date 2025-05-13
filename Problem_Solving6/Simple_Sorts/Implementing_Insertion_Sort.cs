using System;

class InsertionSortExample
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

        insertionSort(arr);
        Console.WriteLine("\nInserted array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.ReadKey();
    }

    static void insertionSort(int[] arr)
    {
        int n = arr.Length;
        for(int i=1; i<n ; i++)
        {
            int j = i - 1;
            int key = arr[i];
            while( j>= 0 && arr[j] > key )
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
       
    }
}