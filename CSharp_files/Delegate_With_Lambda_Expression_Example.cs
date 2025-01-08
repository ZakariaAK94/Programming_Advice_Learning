using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    public class clsBook
    {
        public float Price { get; set; }
        public string Title { get; set; }

        public clsBook(string Title, float Price)
        {
            this.Title = Title;
            this.Price = Price;
        }
    }
    class Program
    {
        delegate bool PredicateBook(clsBook Book);
        static bool CheckIfPriceIsGreatherThan30(clsBook book) => book.Price >= 30f;
        static bool CheckIfPriceIsLessThan20(clsBook book) => book.Price <= 20f;
        static bool CheckIfTitleStartWithR(clsBook book) => book.Title.StartsWith("R");

        static int  CountBooks(List<clsBook> Books, PredicateBook Predicate)
        {
            int Count = 0;
            foreach (clsBook book in Books)
            {
                if(Predicate(book))
                    Count++;

            }
            return Count;
        }



        static void Main(string[] args)
        {
            List<clsBook> books = new List<clsBook>()
            {
                new clsBook("Reda",19.23f),
                new clsBook("Karim",90.5f),
                new clsBook("Mahmoud",10.66f)
            };
            Console.WriteLine(CountBooks(books, CheckIfPriceIsGreatherThan30));
            Console.WriteLine(CountBooks(books, CheckIfPriceIsLessThan20));
            Console.WriteLine(CountBooks(books, CheckIfTitleStartWithR));
            Console.ReadLine();
        }

       
    }
}
