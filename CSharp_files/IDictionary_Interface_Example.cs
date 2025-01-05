using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IDictionaryInterfaceExample
{

    public class SimpleCustomColl<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _list = new List<KeyValuePair<TKey, TValue>>();
        public TValue this[TKey key] 
        {
            get
            {
                foreach(var kpv in _list)
                {
                    if(Equals(kpv.Key, key))
                        return kpv.Value;
                }
                throw new KeyNotFoundException($"the given key '{key}' doesn't exist in the current dictionary");
            }
             set
            {
                bool IsFound = false;
                for(int i=0;i<_list.Count;i++)
                {
                    if (Equals(_list[i].Key, key))
                    {
                        _list[i] = new KeyValuePair<TKey, TValue>(key, value);
                        IsFound = true;
                        break;
                    }
                }
                if(!IsFound) _list.Add(new KeyValuePair<TKey, TValue>(key,value));  

            }
        }

        public ICollection<TKey> Keys => _list.ConvertAll(kpv=>kpv.Key);//Result: ConvertAll creates a new List<TKey> where each element is the Key of
         //the corresponding KeyValuePair<TKey, TValue> in _list.
         //Type: The result is a List<TKey>, which is automatically cast to ICollection<TKey>, fulfilling the return type of the Keys property.

        public ICollection<TValue> Values => _list.ConvertAll(kpv => kpv.Value);

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(TKey key, TValue value)
        {
            foreach(var kpv in _list)
            {
                if (Equals(kpv, key))
                    throw new ArgumentException("the key is already exist in the list");
            }
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
           return _list.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            foreach (var kpv in _list)
                if (Equals(kpv.Key,key))
                {
                    return true;
                }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public bool Remove(TKey key)
        {            
            for (int i = 0; i < _list.Count; i++)
            {
                if (Equals(_list[i].Key, key))
                {
                    _list.RemoveAt(i);
                    return true;
                }
            }            
            return false;
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return _list.Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach(var kpv in _list)
            {
                if(Equals(kpv.Key, key))
                {
                    value = kpv.Value;
                    return true;
                }
            }
            value = default(TValue);
            return false;
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
            // Create an instance of SimpleDictionary
            var myDictionary = new SimpleCustomColl<int, string>();


            // Adding elements to the dictionary
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");


            // Accessing an element by key
            Console.WriteLine($"Element with key 2: {myDictionary[2]}");


            // Updating an element by key
            myDictionary[2] = "Two Updated";
            Console.WriteLine($"Updated element with key 2: {myDictionary[2]}");


            // Iterating over the dictionary
            Console.WriteLine("\nIterating over the dictionary:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            // Demonstrate the ContainsKey and Remove functionality
            if (myDictionary.ContainsKey(3))
            {
                Console.WriteLine("\nContains key 3, removing...");
                myDictionary.Remove(3);
            }

            // Display the dictionary after removal
            Console.WriteLine("\nDictionary after removing key 3:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            Console.ReadLine();
        }
    }
}
