using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementAQueueUsingStacks
{
    public class Program
    {
        public class myQueue
        {
            private Stack<int> _stack1;
            private Stack<int> _stack2;

            public myQueue()
            {
                _stack1 = new Stack<int>();
                _stack2 = new Stack<int>();
            }

            public void enqueue(int x)
            {
                _stack1.Push(x);
            }

            public int dequeue() 
            {
                if (_stack2.Count == 0 && _stack1.Count==0)
                    throw new InvalidOperationException("the queue is empty");

                if(_stack2.Count ==0)
                {
                    while(_stack1.Count > 0)
                    {
                        _stack2.Push(_stack1.Pop());
                    }                    
                }

                 return _stack2.Pop();
                
            }

            public int peek()
            {
                if (_stack2.Count == 0 && _stack1.Count == 0)
                    throw new InvalidOperationException("the queue is empty");

                if (_stack2.Count == 0)
                {
                    while (_stack1.Count > 0)
                    {
                        _stack2.Push(_stack1.Pop());
                    }
                }
                int front = _stack2.Pop();
                _stack2.Push(front);
                return _stack2.Peek();
            }

            public bool empty()
            {
               return  _stack2.Count == 0 && _stack2.Count == 0;
            }


        }
        static void Main(string[] args)
        {
            myQueue test = new myQueue();
            test.enqueue(1);
            test.enqueue(2);
            test.enqueue(3);

            Console.WriteLine(test.peek()) ;
            Console.WriteLine(test.dequeue());
            Console.WriteLine(test.peek());
            Console.WriteLine(test.empty());

            Console.ReadKey();
        }
    }
}
