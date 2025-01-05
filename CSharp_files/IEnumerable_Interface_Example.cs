using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CustomCollectionExample
{
    public class CustomCollection<T>: IEnumerable<T>
    {
        private List<T> items = new List<T>();           
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i]; //GetEnumerator Method: This method uses yield return to lazily return each item in the collection. yield return is used to
                                       //produce an iterator that incrementally returns values to the caller.
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return  GetEnumerator();
        }

        public void Add(T item)
        {
            items.Add(item);
        }       
    }  

    /*6--Read-Only Iteration: IEnumerable is perfect for scenarios where you need to iterate over a collection without modifying it. It provides a way 
      to expose the collection to clients without giving them the ability to change its contents. */
    public class ReadOnlyCollectionWrapper<T> : IEnumerable<T>
    {
        private readonly List<T> _items;

        public ReadOnlyCollectionWrapper(List<T> items)
        {
            _items = items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Program
    {
       
        static void Main(string[] args)
        {

            //var myCollection = new CustomCollection<int>();
            //myCollection.Add(1);
            //myCollection.Add(2);
            //myCollection.Add(3);
            // This method can now work with any collection that implements IEnumerable

            /* 1--Abstraction and Flexibility
             Standardization: IEnumerable provides a common interface for iterating over any collection, whether it's an array, list, set, dictionary, or even
             a custom collection. This standardization means that code written to work with IEnumerable can work with any type of collection that implements 
             this interface.
             Decoupling: By relying on interfaces like IEnumerable, you decouple the code from specific collection implementations. This means that your code
            can be more flexible and easier to maintain, as you can change the underlying collection type without changing the code that uses it.*/
            void PrintCollection(IEnumerable<string> collection) // u can use object
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item + " ");
                }
            }
            var list = new List<string> { "apple", "banana", "cherry" };
            PrintCollection(list);
            var array = new string[] { "dog", "cat", "mouse" };
            PrintCollection(array);
            /*2--Interoperability with LINQ: LINQ (Language Integrated Query) is built on IEnumerable and IQueryable. It allows for powerful querying and 
            transformation of data in a consistent manner across different types of collections. LINQ can operate on any data source that implements 
            IEnumerable, whether it's in-memory collections, databases, XML, or even remote data sources.*/
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            /*3--Deferred Execution: IEnumerable supports deferred execution, meaning that the actual execution of a query or operation is delayed until you
            actually iterate over the collection.This can lead to performance optimizations,especially with large data sets or expensive operations.*/
            IEnumerable<int> GetNumbers()
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return i;
                }
            }

            var numbers1 = GetNumbers(); // No iteration happens here, deferred execution

            /*4--Unified Access to Collections: Using IEnumerable ensures that you can iterate over any collection in a uniform way. This is particularly
             useful in methods that need to handle multiple types of collections without needing to know their specific types. */
            void ProcessItems(IEnumerable<object> items)
            {
                foreach (var item in items)
                {
                    // Process each item, no need to know the concrete collection type
                    Console.WriteLine(item);
                }
            }
            // ProcessItems can be called with different collection types
            ProcessItems(new List<object> { 1, "two", 3.0 });
            ProcessItems(new object[] { "a", "b", "c" });

            /* 5--Simplifying Method Signatures: When you want a method to accept any collection that can be iterated over, you can use IEnumerable in the 
              method signature. This simplifies method signatures and makes your code more general and reusable. */
            // Instead of requiring a List<T> or T[], you can use IEnumerable<T>
            void PrintNames(IEnumerable<string> names)
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }

            /*
             Conclusion: Collection interfaces like IEnumerable are vital for creating flexible, maintainable, and reusable code. They provide a consistent way to 
            interact with various types of collections, enable the use of LINQ, support deferred execution, and allow for clean, generalized code that is not 
            tightly coupled to specific collection types.
             */
            List<string> namesTest = new List<string> { "apple", "banana", "cherry" };
            ReadOnlyCollectionWrapper<string> test = new ReadOnlyCollectionWrapper<string>(namesTest);
            PrintCollection(test);

            Console.ReadLine();
        }
    }
}
