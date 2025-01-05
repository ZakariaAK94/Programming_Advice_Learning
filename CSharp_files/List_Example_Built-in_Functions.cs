using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            numbers.Add(16);
            Console.WriteLine("\nAfter adding 16 : " + string.Join("<->", numbers));
            numbers.Insert(0, 100);
            Console.WriteLine("\nAfter adding 100 at beginning : " + string.Join("<->", numbers));
            numbers.InsertRange(3, new List<int> { 300, 400 });
            Console.WriteLine("\nAfter inserting 300 and 400 after index 3 : " + string.Join("<->", numbers));
            numbers.Remove(300);
            Console.WriteLine("\nAfter removing 300 : " + string.Join("<->", numbers));

            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 7, 8, 11, 10, 13, 14, 16, 17 };

            List<int> IsEven = new List<int>();
            List<int> IsOdd = new List<int>();
            Console.WriteLine("\n original list 2 :\n " + string.Join("<->", numbers1));
            foreach (int i in numbers1)
            {
                if(i % 2 == 0)
                    IsEven.Add(i);
                else
                    IsOdd.Add(i);
            }
            numbers1.Clear();
            numbers1.InsertRange(0,IsEven);
            int CountEvenNbr = IsEven.Count;
            numbers1.InsertRange(CountEvenNbr, IsOdd);
            Console.WriteLine("\nAfter reorder the list numbers1 first Even Numbers and then Odd Numbers :\n " + string.Join("<->", numbers1));
            numbers1.RemoveAll(n => n%3 == 0);
            Console.WriteLine("\nAfter removing the numbers are divided by 3 :\n " + string.Join("<->", numbers1));
            numbers1.RemoveAll(n=>n%5==0);
            Console.WriteLine("\nAfter removing the numbers are divided by 5 :\n " + string.Join("<->", numbers1));
            numbers1.RemoveAll(n=>n%4==0);
            Console.WriteLine("\nAfter removing the numbers are divided by 4 :\n " + string.Join("<->", numbers1));
            numbers1.RemoveAt(numbers1.Count-1);
            Console.WriteLine("\nAfter removing the last numbers :\n " + string.Join("<->", numbers1));
            Console.ReadLine();
        }
    }
}
