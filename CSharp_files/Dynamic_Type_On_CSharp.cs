﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypeOnCsharpPRadvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1} ",MyDynamicVar, MyDynamicVar.GetType());
            MyDynamicVar = "Hello World!";
            Console.WriteLine("Value: {0}, Type: {1} ",MyDynamicVar, MyDynamicVar.GetType());
            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1} ",MyDynamicVar, MyDynamicVar.GetType());
            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1} ",MyDynamicVar, MyDynamicVar.GetType());

            Console.ReadKey();



        }
    }
}
