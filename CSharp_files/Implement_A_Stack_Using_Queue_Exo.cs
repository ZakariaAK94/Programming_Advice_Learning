using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ImplementAStackUsingQueuesExo
{
    public class Program
    {
        public class StackUsingQueues
        {
            private Queue<int> _Queue1;
            private Queue<int> _Queue2;

            public StackUsingQueues()
            {
                _Queue1 = new Queue<int>();
                _Queue2 = new Queue<int>();
            }

            public void push(int value)
            {
                _Queue2.Enqueue(value);
                
                while(_Queue1.Count > 0)
                {
                    _Queue2.Enqueue(_Queue1.Dequeue());
                }

                //swap by name
                var temp = _Queue2;
                _Queue2 = _Queue1;
                _Queue1 = temp;
            }
            // Pop the top element from the stack
            public void pop()
            {
                if (_Queue1.Count > 0)    // Removes the top (front) element of _Queue1
                {
                    _Queue1.Dequeue();
                    return;
                }                
                throw new InvalidOperationException("The stack is empty");

            }

            public int top()
            {
                if(_Queue1.Count==0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                int topelem = _Queue1.Dequeue();
                _Queue2.Enqueue(topelem);
                while (_Queue1.Count > 0)
                {
                    int elem = _Queue1.Dequeue();
                    _Queue2.Enqueue(elem);
                }
                var temp = _Queue2;
                _Queue2 = _Queue1;
                _Queue1 = temp;

                return topelem;
            }

            // Check if the stack is empty
            public bool empty()
            {
                return _Queue1.Count == 0;  
            }
        }
    
        static void Main(string[] args)
        {
            StackUsingQueues stack = new StackUsingQueues();
            stack.push(1);
            stack.push(2);
            Console.WriteLine(stack.top()); // Should return 2
            stack.pop();
            Console.WriteLine(stack.top()); // Should return 1
            Console.WriteLine(stack.empty()); // Should return false

            Console.ReadLine();
        }
    }
}
