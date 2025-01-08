using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEvent
{
    internal class Program
    {
        public delegate void PriceChangedHandler(Stock stock, decimal OldPrice);

        // Publisher 
        public class Stock
        {
            private string name;
            private decimal price;

            public string Name => this.name;
            public decimal Price { get => this.price; set => this.price = value; }

            public Stock(string stockname)
            {
                this.name = stockname;
            }

            // this is what is new in this code to understand
            public event PriceChangedHandler OnPriceChanged;

            public void changeStockPriceBy(decimal percent)
            {
                decimal OldPrice = this.price;
                this.price += Math.Round(this.price * percent, 2);
                
                OnPriceChanged?.Invoke(this, OldPrice);
                
            }


        }

        private static void Stock_OnPriceChanged(Stock stock, decimal OldPrice)
        {
            string result = "";
            string message = "";
            if (OldPrice < stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "Up";
                message = "Here is a second subscribe : my advice is to invest now.";
            }
            else if (OldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "Down";
                message = "Here is a second subscribe : my advice is to  avoid investing now.";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                result = "Stable";
                message = "Here is a second subscribe : my advice is to  avoid investing now.";
            }

            Console.WriteLine($"{stock.Name} ${OldPrice} to ${stock.Price} - {result} ");
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;

            stock.OnPriceChanged += Stock_OnPriceChanged;     

            stock.changeStockPriceBy(0.05m);
            stock.changeStockPriceBy(-0.05m);
            stock.changeStockPriceBy(0.00m);

            Console.ReadLine();
        }

        
    }

   
}
