using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackInCSharpExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> items = new Stack<int>();
            items.Push(1);
            items.Push(2);                
            items.Push(3);
            items.Push(4);

            //while(items.Count!=0)
            //{
            //    Console.WriteLine(items.Pop());
            //}
            Console.WriteLine("Top elements: "+items.Peek());
            //Popping elements from the stack
            Console.WriteLine("Popped: "+items.Pop());
            Console.WriteLine("Popped: "+items.Pop());
            //Checking if the stack is empty
            if(items.Count==0)
            {
                Console.WriteLine("Stack is Empty");
            }else
            {
                Console.WriteLine("The top element is: "+items.Peek());
            }
            Console.WriteLine("the count of items is:"+items.Count);

            Stack<int> items1 = new Stack<int>();
            items1.Push(1);
            items1.Push(2);
            items1.Push(3);
            items1.Push(4);
            items1.Reverse(); //Understanding stack.Reverse()stack.Reverse() does not modify the original stack.
                              //Instead, it returns a new reversed sequence of elements.
                              //It is a LINQ method that returns an IEnumerable<T>,which you can iterate over, but it does not mutate the stack itself.

            // or we can use this:
            Stack<int> stack = new Stack<int>(items1.Reverse());
            // or we use list
            List<int> list = new List<int>(items1);
            //list.Reverse();
            items1.Clear();
            foreach (var p in list)
            {
                items1.Push(p);
            }

            // or this one
            Stack<int> stack1 = new Stack<int>();
            while(items1.Count > 0)
            {
                stack1.Push(items1.Pop());
            }   

            Console.WriteLine("Top elements: " + items1.Peek());
            //Popping elements from the stack
            Console.WriteLine("Popped: " + items1.Pop());
            Console.WriteLine("Popped: " + items1.Pop());
            //Checking if the stack is empty
            if (items1.Count == 0)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("The top element is: " + items1.Peek());
            }
            Console.WriteLine("the count of items is:" + items1.Count);
            Console.ReadLine();
        }
    }
}
