using System;
using System.Collections.Generic;
using System.Xml.Linq;


public class MaxHeap
{
    private List<int> _heap = new List<int>();
    public void Insert(int value)
    {
        _heap.Add(value);

        HelpifyUp(_heap.Count - 1);

    }

    private void HelpifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;

            if (_heap[index] < _heap[parentIndex]) break;

            (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);

            index = parentIndex;
        }

    }
    public int Peek()
    {
        if (_heap.Count == 0)
            throw new InvalidOperationException("_heap is empty");

        return _heap[0];

    }

    public int ExtractMin()
    {
        int maxValue = _heap[0];
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];

        _heap.RemoveAt(lastIndex);

        HelpifyDown(0);


        return maxValue;
    }


    private void HelpifyDown(int index)
    {
        while (index < _heap.Count)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;

            int largestIndex = index;

            if (leftChildIndex < _heap.Count && _heap[leftChildIndex] > _heap[largestIndex])
                largestIndex = leftChildIndex;

            if (rightChildIndex < _heap.Count && _heap[rightChildIndex] > _heap[largestIndex])
                largestIndex = rightChildIndex;

            if (largestIndex == index) break;

            (_heap[largestIndex], _heap[index]) = (_heap[index], _heap[largestIndex]);

            index = largestIndex;

        }

    }

    public void DisplayHeap()
    {
        if (_heap.Count == 0)
            throw new InvalidOperationException("_heap is empty");
        foreach (int i in _heap)
            Console.Write(i + " ");
    }
}


public class MinHeap
{
    private List<int> heap = new List<int>();


    public void Insert(int value)
    {
        heap.Add(value);

        HeapifyUp(heap.Count - 1);
    }

    private void HeapifyUp(int index)
    {

        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;

            if (heap[index] >= heap[parentIndex]) break;

            (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);


            index = parentIndex;
        }
    }


    public int Peek()
    {

        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        return heap[0];
    }

    public int ExtractMin()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        int minValue = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);
        return minValue;
    }
    private void HeapifyDown(int index)
    {

        while (index < heap.Count)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;

            int smallestIndex = index;


            if (leftChildIndex < heap.Count && heap[leftChildIndex] < heap[smallestIndex])
                smallestIndex = leftChildIndex;


            if (rightChildIndex < heap.Count && heap[rightChildIndex] < heap[smallestIndex])
                smallestIndex = rightChildIndex;


            if (smallestIndex == index) break;

            (heap[index], heap[smallestIndex]) = (heap[smallestIndex], heap[index]);

            index = smallestIndex;
        }
    }

    public void DisplayHeap()
    {
        Console.WriteLine("\nHeap Elements: ");
        foreach (int value in heap)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        MinHeap minHeap = new MinHeap();
        MaxHeap maxHeap = new MaxHeap();

        Console.WriteLine("Inserting elements into the Min-Heap...\n");
        minHeap.Insert(10);
        minHeap.Insert(4);
        minHeap.Insert(15);
        minHeap.Insert(2);
        minHeap.Insert(8);

        minHeap.DisplayHeap();

        Console.WriteLine("\nPeek Minimum Element: Minimum Element is: " + minHeap.Peek());

        minHeap.DisplayHeap();


        Console.WriteLine("\nExtracting elements from the Min-Heap:");
        Console.WriteLine("Extracted Minimum: " + minHeap.ExtractMin());
        minHeap.DisplayHeap();

        Console.WriteLine("\nExtracted Minimum: " + minHeap.ExtractMin());
        minHeap.DisplayHeap(); 
       
        Console.ReadKey();

    }
}
