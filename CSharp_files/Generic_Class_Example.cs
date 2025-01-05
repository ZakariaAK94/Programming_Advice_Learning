using System;

public class GenericBox<T>
{
    private T Result;

    public GenericBox(T Result)
    {
        this.Result = Result;
    }

    public void GatherElements(T[] Array)
    {
        dynamic result = default(T);
        foreach (var item in Array)
        {
            result += item;
        }
        this.Result = result;
    }

    public T GetResult()
    {
        return this.Result;    
    }
}

public class Program
   {
       static void Main(string[] args)
       {
        //usage with integer
        GenericBox<int> intBox = new GenericBox<int> (50);
        Console.WriteLine("Content of intBox: "+intBox.GetResult());
        //usage with string
        GenericBox<string> stringBox = new GenericBox<string>("AKIL");
        Console.WriteLine("Content of stringBox: " + stringBox.GetResult());

        int[] intArray1 = {1,2,3,4};
        intBox.GatherElements(intArray1);
        Console.WriteLine("Content of intBox with Array is : " + intBox.GetResult());
        string[] stringArray2 = {"I"," Will be"," The best programmer"," in the world"," Inshaallah"};
        stringBox.GatherElements(stringArray2);
        Console.WriteLine("Content of intBox with Array is : " + stringBox.GetResult());

        Console.ReadLine();



       }
   }

