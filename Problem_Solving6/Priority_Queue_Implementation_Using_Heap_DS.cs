using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class PriorityQueue
{
    public int Priority { get; set; }
    public string Name { get; set; }

    public PriorityQueue(string name, int priority)
    {
        Name = name;
        Priority = priority;            
    }
}

public class MinHeapPriorityQueue
{
    private List<PriorityQueue> _heap = new List<PriorityQueue>();
    public void Insert(string task, int priority)
    {
        _heap.Add(new PriorityQueue(task, priority));

        HelpifyUp(_heap.Count - 1);

    }

    private void HelpifyUp(int index) 
    {
        while(index > 0)
        {
            int parentIndex = (index - 1) / 2;

            if (_heap[index].Priority > _heap[parentIndex].Priority) break;

            (_heap[index],_heap[parentIndex]) = (_heap[parentIndex] ,_heap[index]);

            index=parentIndex;
        }
    
    }
    public PriorityQueue Peek() 
    {
        if (_heap.Count == 0)
            throw new InvalidOperationException("_heap is empty");
       
        return _heap[0];
    
    }

    public PriorityQueue ExtractTask()
    {
        var maxValue = _heap[0];
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];

        _heap.RemoveAt(lastIndex);

        HelpifyDown(0);


        return maxValue;
    }


    private void HelpifyDown(int index)
    {
        while(index < _heap.Count)
        {
            int leftChildIndex = 2 * index+1;
            int rightChildIndex = 2 * index+2;

            int largestIndex = index;

            if(leftChildIndex < _heap.Count && _heap[leftChildIndex].Priority < _heap[largestIndex].Priority)
                    largestIndex = leftChildIndex;

            if (rightChildIndex < _heap.Count && _heap[rightChildIndex].Priority < _heap[largestIndex].Priority)
                    largestIndex = rightChildIndex;

            if (largestIndex == index) break;

            (_heap[largestIndex], _heap[index]) = (_heap[index], _heap[largestIndex]);

            index = largestIndex;

        }

    }

}
public class MinHeapWithEnum
{
    private List<PriorityQueue> _heap = new List<PriorityQueue>();
    public void Insert(string task, int priority)
    {

        _heap.Add(new PriorityQueue(task, priority ));

        HelpifyUp(_heap.Count - 1);

    }

    private void HelpifyUp(int index) 
    {
        while(index > 0)
        {
            int parentIndex = (index - 1) / 2;

            if (_heap[index].Priority > _heap[parentIndex].Priority) break;

            (_heap[index],_heap[parentIndex]) = (_heap[parentIndex] ,_heap[index]);

            index=parentIndex;
        }
    
    }
    public PriorityQueue Peek() 
    {
        if (_heap.Count == 0)
            throw new InvalidOperationException("_heap is empty");
       
        return _heap[0];
    
    }

    public PriorityQueue  ExtractTask()
    {
        var maxValue = _heap[0];
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];

        _heap.RemoveAt(lastIndex);

        HelpifyDown(0);


        return maxValue;
    }


    private void HelpifyDown(int index)
    {
        while(index < _heap.Count)
        {
            int leftChildIndex = 2 * index+1;
            int rightChildIndex = 2 * index+2;

            int largestIndex = index;

            if(leftChildIndex < _heap.Count && _heap[leftChildIndex].Priority < _heap[largestIndex].Priority)
                    largestIndex = leftChildIndex;

            if (rightChildIndex < _heap.Count && _heap[rightChildIndex].Priority < _heap[largestIndex].Priority)
                    largestIndex = rightChildIndex;

            if (largestIndex == index) break;

            (_heap[largestIndex], _heap[index]) = (_heap[index], _heap[largestIndex]);

            index = largestIndex;

        }

    }

}
public class Program
{
    public static void Main()
    {

        MinHeapPriorityQueue pq = new MinHeapPriorityQueue();

        Console.WriteLine("Inserting elements into the Priority Queue...\n");

        Console.WriteLine("Inserting (Task 1, 5)");
        Console.WriteLine("Inserting (Task 2, 3)");
        Console.WriteLine("Inserting (Task 3, 4)");
        Console.WriteLine("Inserting (Task 4, 1)");
        Console.WriteLine("Inserting (Task 5, 2)");

        pq.Insert("Task 1", 5);
        pq.Insert("Task 2", 3);
        pq.Insert("Task 3", 4);
        pq.Insert("Task 4", 1);
        pq.Insert("Task 5", 2);

        
        Console.WriteLine("\nPeek Minimum Priority Element: Name = " + pq.Peek().Name + ", Priority = " + pq.Peek().Priority);

        Console.WriteLine("\nExtracting elements from the Priority Queue:");
        var extractedNode = pq.ExtractTask();
        Console.WriteLine("\nExtracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

        extractedNode = pq.ExtractTask();
        Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

        extractedNode = pq.ExtractTask();
        Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

        extractedNode = pq.ExtractTask();
        Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);

        extractedNode = pq.ExtractTask();
        Console.WriteLine("Extracted Element: Name = " + extractedNode.Name + ", Priority = " + extractedNode.Priority);
        Console.ReadKey();

    }
}
