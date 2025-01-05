using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListInterfaceExample
{

    public class CustomCollectionUsingList<T> : IList<T>
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;
        public bool IsReadOnly => false;
        public void Add(T item) => _items.Add(item);
        public void Clear() => _items.Clear();
        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
        public bool Remove(T item) => _items.Remove(item);
        public bool Contains(T item) => _items.Contains(item);
        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();


        public T this[int index] { get => _items[index]; set => _items[index]=value; }
        public void RemoveAt(int index) => _items.RemoveAt(index);
        public int IndexOf(T item) => _items.IndexOf(item);       
        public void Insert(int index, T item) => _items.Insert(index, item);
       

    }

    public class Program
    {
        static void Main(string[] args)
        {
            CustomCollectionUsingList<string> myList = new CustomCollectionUsingList<string>();
            myList.Add("First");
            myList.Add("Second");
            myList.Insert(1, "Inserted");


            Console.WriteLine("List after adding and inserting:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }


            myList.RemoveAt(1); // Removes "Inserted"
            myList[0] = "Updated First"; // Update the first item


            Console.WriteLine("\nList after removing and updating:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
