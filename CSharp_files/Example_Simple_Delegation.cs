using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCsharp
{
    internal class Program
    {
        public class EventDemo
        {
            // Define a delegate
            public delegate void MyEventHandler(string message);

            // Define an event based on the delegate
            public event MyEventHandler MyEvent;

            private string message;

            public string Message
            {
                get =>message; 
                set => this.message = value;
            }

            // Method to raise the event
            public void RaiseEvent()
            {
                MyEvent?.Invoke(message);
            }
        }

        public static void MyEventHandlerMethod(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            EventDemo Demo = new EventDemo();
            Demo.Message = "this is an event handled!";
            Demo.MyEvent += MyEventHandlerMethod;
            Demo.RaiseEvent();
            Console.ReadLine(); 

        }
    }
}
