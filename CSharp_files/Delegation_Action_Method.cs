using System;

public class Program
{
    static void Main(string[] args)
    {
        Action parameterlessAction = ParameterLessAction;
        Action <int> parameterActionWithOneparameter = ParameterActionWithOneParameter;
        Action <int,string> parameterActionWithTwoparameters = ParameterActionWithTwoParameters;

        parameterlessAction();
        parameterActionWithOneparameter(5);
        parameterActionWithTwoparameters(30, "Zakaria AKIL");






        Console.ReadLine();

    }

    private static void ParameterLessAction()
    {
        Console.WriteLine("this is a call method without parameter.");
    }

    private static void ParameterActionWithOneParameter(int x)
    {
        Console.WriteLine($"this is a call method with one parameter x = {x}.");
    }

    private static void ParameterActionWithTwoParameters(int age, string name)
    {
        Console.WriteLine($"this is a call method with two parameters: My name is {name} and  I am {age}.");
    }
}
