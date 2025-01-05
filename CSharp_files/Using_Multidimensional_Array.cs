using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAMultidimensionalArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example how to use matrix
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };
            for(int i= 0; i < matrix.GetLength(0); i++)
            {
                for(int j= 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            int[] original = {1,2,3,4,5 };
            int[] copy = new int[5];

            Array.Copy(original,copy,original.Length);
            foreach(int element in copy)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
