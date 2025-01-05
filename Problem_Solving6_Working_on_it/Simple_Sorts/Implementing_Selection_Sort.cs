using System;

class SelectionSortExample
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

        SelectionSort(arr, true);

        Console.WriteLine("\nSorted array Ascendant:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        SelectionSort(arr, false);
        Console.WriteLine("\nSorted array Descendant:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
         }

        Console.ReadKey();
    }
  
    static void SelectionSort(int[] arr, bool isAscOrder)
    {
        int n = arr.Length;
        for (int i = 0; i < n-1 ; i++)
        {
            int minIndex = i;
            for (int j = i+1; j < n ; j++)
            {
                if (isAscOrder ? arr[j] < arr[minIndex] : arr[j] > arr[minIndex])
                {
                    minIndex = j ;
                }
            }
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
    }

}