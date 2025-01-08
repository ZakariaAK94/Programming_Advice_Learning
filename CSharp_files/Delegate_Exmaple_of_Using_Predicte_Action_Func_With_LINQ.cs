using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
class Program
{
    static void Main()
    {
        // expression lambda that returns the square of a number 
        Func<int,int> square =  num => num * num;
        int z = 8;
        Console.WriteLine($"Square of number {z}: {square(z)}");

        Func<string, string, string> concatination = (str1, str2) => str1 + str2;
        string result = concatination("Hello", "World");
        Console.WriteLine(result);

        Func<int,int,int> sum = (c, b) => c + b;
        int b1 = 10;
        int c1 = 13;
        // passing input to the expression lambda 
        Console.WriteLine($"sum of number {b1} and {c1}: {sum(b1, c1)}");

        Predicate<int> isEven = x => x % 2 == 0; // take one argument and return bool
        Predicate<int> isOdd = x => x % 2 != 0;
        Predicate<int> isPositive = x => x > 0;
        
        List<int> numbers = new List<int> { -1, 2, -3, -4, 5, 6, 7, 8, -9, 10 };

        // Using a lambda expression to filter even numbers
        List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        List<int> oddNumbers = numbers.Where(num => num % 2 != 0).ToList();
        List<int> positiveNumbers = numbers.Where(num => num >0).ToList();
        Console.WriteLine("Even Numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("odd Numbers:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("positive Numbers:");
        foreach (var number in positiveNumbers)
        {
            Console.WriteLine(number);
        }

        Action<string> printMessage = message => Console.WriteLine(message);
        Action printMessage1 = () => Console.WriteLine("Hello Zakaria");

        Action<int> displayMsg = message => Console.WriteLine("my age is "+message);

        printMessage("Hello Zakaria");
        printMessage1();

        displayMsg(30);


        Console.ReadLine();
    }
}
