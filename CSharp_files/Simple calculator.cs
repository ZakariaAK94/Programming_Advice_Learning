using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Simple Calculator
            //char op;
            //double firstNumber, secondNumber, result;
            //Console.Write("Enter First Number: ");
            //firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second Number: ");
            //secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter operator (+, -, *, /): ");
            //op = (char)Console.Read();

            //switch (op)
            //{
            //    case '+':
            //        result = firstNumber + secondNumber;
            //        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
            //        break;
            //    case '*':
            //        result = firstNumber * secondNumber;
            //        Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
            //        break;
            //    case '/':
            //        result = firstNumber / secondNumber;
            //        Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
            //        break;
            //    case '-':
            //        result = firstNumber - secondNumber;
            //        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation ");
            //        break;
            //}

            Console.WriteLine("Please enter UserName");
            var UserName = Console.ReadLine();

            switch(UserName)
            {
                case "Zakaria":
                    Console.WriteLine("You are welcome M. Zakaria");
                    break;
                default:
                    Console.WriteLine("Invalid UserName, please try again");
                    break;
            }

            Console.ReadKey();  

        }
    }
}
