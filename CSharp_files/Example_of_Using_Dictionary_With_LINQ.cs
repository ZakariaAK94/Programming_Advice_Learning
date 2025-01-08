using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> fruitBasket = new Dictionary<string,int>();

            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Banana", 15);
            fruitBasket.Add("Orange", 10);
            fruitBasket.Add("Perry", 7);
            fruitBasket["Grape"]= 17;

            int AppleQuantity = fruitBasket["Apple"];

            Console.WriteLine($"the quantity of the apple in fruitBasket is {AppleQuantity}.");

            if (fruitBasket.ContainsKey("Apple"))
                Console.WriteLine("Apple exists in the fruitBasket");

            fruitBasket["Banana"] = 17;          
            

            if(fruitBasket.Remove("Orange"))
            {
                Console.WriteLine("Orange was deleted correctly.");
            }
            else
            {
                Console.WriteLine("Error:Orange failed to be deleted.");
            }

            Console.WriteLine($"number of elements in the fruitBasket is {fruitBasket.Count}");

            foreach(KeyValuePair<string,int> item in fruitBasket)
            {
                Console.WriteLine($"the fruit is {item.Key} and the quantity is {item.Value}.");
            }

            foreach (var item in fruitBasket)
            {
                Console.WriteLine($"the fruit is {item.Key} and the quantity is {item.Value}.");
            }

            if(fruitBasket.TryGetValue("Orange",out int OrangeQte))
            {
                Console.WriteLine($"Orange qte is {OrangeQte}");
            }else
            {
                Console.WriteLine($"Orange doesn't exist in the fruitbasket");
            }
            // that's why we need to use trygetvalue to avoid runtime error
            //Console.WriteLine($"Orange qte is {fruitBasket["Orange"]}");

            if (fruitBasket.ContainsValue(17))
            {
                Console.WriteLine("There are at least one fruit with Qte 17.");
            }

            Dictionary<string, int> fruitBasket1 = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Banana", 15 },
                {"Orange", 10 }
            };

            //Using LINQ to transform items
            //transform data from dictionary to collection of object (anynomous)
            var fruitInfo = fruitBasket1.Select(kpv => new { kpv.Key, kpv.Value });
            //transform items
            Console.WriteLine("Transformed items:");
            foreach(var kpv in fruitInfo)
            {
                Console.WriteLine($"fruist : {kpv.Key}, Quantity: {kpv.Value} ");
            }

           var fruitInfo2 = fruitBasket1.Where(kpv => kpv.Value >= 10 && kpv.Key.Contains("r"));
            if (fruitInfo == null)
                throw new ArgumentException("the fruitInfo2 is empty");
            Console.WriteLine("The fruit contain 'r' and qte greather than 10 is:");
            foreach (var kpv in fruitInfo2)
            {
                Console.WriteLine($"fruist : {kpv.Key}, Quantity: {kpv.Value} ");
            }

            Dictionary<string, string> fruitCategory = new Dictionary<string, string>
            {
                {"Apple","Tree"},
                {"Banana","Herb"},
                {"Cherry","Tree"},
                {"Strawberry","Bush"},
                {"Raspberrry","Bush"}
            };

            var groupedfruits = fruitCategory.GroupBy(k => k.Value);  

            foreach( var group in groupedfruits)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach(var fruit in  group)
                    Console.WriteLine($" - {fruit.Key}");
            }
            //another dictionary fro combined query
            Dictionary<string,int> fruitBaskt2 = new Dictionary<string, int>
            {
                {"Apple",5},
                {"Banana",8},
                {"Orange",10}
            };

            var sortedFilterfruits = fruitBaskt2
                .Where(kpv => kpv.Value > 5)
                .OrderByDescending(kpv => kpv.Key)
                .Select(kpv => new { kpv.Key, kpv.Value });

            foreach( var fruit in sortedFilterfruits)
            {
                Console.WriteLine($"Fruit:{fruit.Key}, Qte: {fruit.Value}");
            }


            Console.ReadKey();

        }
    }
}
