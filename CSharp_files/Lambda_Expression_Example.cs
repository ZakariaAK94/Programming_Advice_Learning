using System;

class Program
{
    // Define a Func delegate for squaring a number using a lambda expression
    static Func<int, int> square = (x) => x * x;
    static Func<int, int> square1 = (int x) => x * x;
    static Func<int, int> square2 = delegate (int x) { return x * x; };
    static Func<int, int> square3 = SquareMethod ;

    static int SquareMethod(int x)
    {
        return x * x;
    }
    static void Main()
    {
        // Use the square Func to square the number 5
        int result = square(5);

        // Print the result
        Console.WriteLine("The square of 5 is: " + result);
        Console.ReadKey();
    }
}
