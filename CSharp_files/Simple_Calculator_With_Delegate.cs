using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SimpleCalculator
{
    public delegate double TypeOfOperation(double x , double y);

    private TypeOfOperation _OnTypeOfOperation;

    public SimpleCalculator(TypeOfOperation onTypeOfOperation)
    {
        _OnTypeOfOperation = onTypeOfOperation;
    }

    public double Calculate(double x , double y)
    {
        return _OnTypeOfOperation(x,y);        
    }
}


public class Program
{

    public static double Addition(double x , double y)
    {
        return x+ y;
    }
    public static double Substraction(double x, double y)
    {
        return x - y;
    }
    public static double Multiplication(double x, double y)
    {
        return x * y;
    }
    static void Main(string[] args)
    {
        SimpleCalculator Operation1 = new SimpleCalculator(Addition);
        SimpleCalculator Operation2 = new SimpleCalculator(Substraction);
        SimpleCalculator Operation3 = new SimpleCalculator(Multiplication);

        Console.WriteLine($"the result for 5 + 7 is {Operation1.Calculate(5, 7)}");
        Console.WriteLine($"the result for 5 - 7 is {Operation2.Calculate(5, 7)}");
        Console.WriteLine($"the result for 5 * 7 is {Operation3.Calculate(5, 7)}");

        Console.ReadLine();
    }
}

