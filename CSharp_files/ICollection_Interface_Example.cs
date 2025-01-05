using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfUsingICollection
{
    public class SimpleCollectionWithList<T> : ICollection<T>
    {
        private List<T> list = new List<T>();
        public int Count => list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array,arrayIndex);
        }      
        public bool Remove(T item)
        {
            return list.Remove(item);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class SimpleCollectionWithArray<T> : ICollection<T>
    {
        private T[] _OrigArray;

        private int _count;
        public int Count => _count;

        public bool IsReadOnly => false;

        public SimpleCollectionWithArray()
        {
            _OrigArray = new T[10];
            _count = 0;
        }
            
        public void Add(T item)
        {    
            
            if( _count >= _OrigArray.Length)
            {
                T[] newArr = new T[_OrigArray.Length * 2];
                Array.Copy(_OrigArray, newArr, _OrigArray.Length);
                newArr[_OrigArray.Length] = item;
                _OrigArray = newArr;
            }
            _OrigArray[_count] = item;
            _count++;
        }

        public void Clear()
        {
            _OrigArray = new T[10];
            _count = 0;
        }

        public bool Contains(T item)
        {
            if(item==null) return false;
            for(int i=0;i<_count;i++)
            {
                if(_OrigArray[i].Equals(item))
                    return true;
            }
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {           
            if(array==null) throw new ArgumentNullException(nameof(Array));
            if(arrayIndex < 0 || arrayIndex+_count>array.Length) throw new ArgumentOutOfRangeException(nameof(arrayIndex));

            Array.Copy(_OrigArray,0,array,arrayIndex,_count);
        }
        public bool Remove(T item)
        {
            if (item == null) return false;
            int index = -1;

            for (int i = 0; i <_count ; i++)
            {
                if (_OrigArray[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1) return false;

            for (int i = index; i < _count; i++)
            {
                _OrigArray[i] = _OrigArray[i+1];
            }

            _count--;

            return true;

        }

       


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _count - 1; i++)
            {
                yield return _OrigArray[i];
            }
            
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }        

    }

    public class CustomCollectionUsingArray<T> : ICollection<T>
    {
        private T[] _OrigArray;
        private int _count;
        public int Count => _count;

        public CustomCollectionUsingArray()
        {
            _OrigArray = new T[10];
            _count = 0;
        }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if(item==null) throw new ArgumentNullException(nameof(item));
            if(_count >= _OrigArray.Length)
            {
                T[] newArr = new T[_OrigArray.Length*2];
                Array.Copy(_OrigArray,newArr,_OrigArray.Length);
                newArr[_count] = item;
                _OrigArray=newArr;
            }
            _OrigArray[_count] = item;
            _count++;
        }

        public void Clear()
        {
            _OrigArray = new T[10];
            _count = 0;
        }

        public bool Contains(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            for(int i=0; i< _OrigArray.Length;i++)
            {
                if (_OrigArray[i].Equals(item)) 
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if(array == null) throw new ArgumentNullException("array");
            if (arrayIndex < 0 || arrayIndex + _count > array.Length) throw new ArgumentOutOfRangeException("out of range");
            Array.Copy(_OrigArray,0,array,arrayIndex,_count);
        }
        public bool Remove(T item)
        {
            if(item == null) return false;
            int IndexOfItem = -1;
            for(int i= 0; i< _OrigArray.Length;i++)
            {
                if (_OrigArray[i].Equals(item))
                    IndexOfItem = i;
                break;
            }

            if(IndexOfItem == -1) return false;

            for (int i = IndexOfItem; i < _OrigArray.Length; i++)
            {
                _OrigArray[i] = _OrigArray[i + 1];
            }
            _count--;
            return true;

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _OrigArray.Length; i++)
            {
                
                    yield return _OrigArray[i];
            }
        }

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    /*
     // this function from chatgpt
        public T[] ResizeArray(T[] originalArray, int newSize)
        {
            // Create a new array with the specified new size
            T[] newArray = new T[newSize];

            // Determine the number of elements to copy (whichever is smaller)
            int elementsToCopy = Math.Min(originalArray.Length, newSize);

            // Copy elements from the original array to the new array
            for (int i = 0; i < elementsToCopy; i++)
            {
                newArray[i] = originalArray[i];
            }

            // Return the new array
            return newArray;
        }
     */



    public class Program
    {

        static void Main(string[] args)
        {
            
            SimpleCollectionWithArray<string> fruits = new SimpleCollectionWithArray<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Orange");

            Console.WriteLine($"Items in cart: {fruits.Count}");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            if(fruits.Contains("Banana"))
            {
                fruits.Remove("Banana");
                Console.WriteLine("Banana removed from the _OrigArray.");
            }
            else
            {
                Console.WriteLine("Banana does not exist in the current _OrigArray.");
            }            
            Console.WriteLine("the _OrigArray fruits after removing Banana:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            Console.ReadKey();  

        }
    }
}
