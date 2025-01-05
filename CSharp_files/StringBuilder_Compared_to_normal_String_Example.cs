using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



public class Program
{
    static void Main(string[] args)
    {
        int iterations = 200000;

        Stopwatch stopwatch1 = Stopwatch.StartNew();
        ConcatenateStrings(iterations);
        stopwatch1.Stop();
        Console.WriteLine($"String concatenation using + operator took : {stopwatch1.ElapsedMilliseconds}ms");

        Stopwatch stopwatch2 = Stopwatch.StartNew();
        ConcatenateStringsWithSB(iterations);
        stopwatch2.Stop();
        Console.WriteLine($"String concatenation using stringbuilder took : {stopwatch2.ElapsedMilliseconds}ms");

        Console.ReadLine();

    }

    public static void ConcatenateStrings(int iterations)
    {
        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "a";
        }
    }

    public static void ConcatenateStringsWithSB(int iterations)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }

        string result = sb.ToString();
    }
}

