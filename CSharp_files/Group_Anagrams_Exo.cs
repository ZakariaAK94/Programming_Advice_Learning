using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagramsExo
{
    public class Program
    {
        public static List<List<string>> GroupAnagrams(string[] Arr)
        {
            if(Arr == null || Arr.Length == 0) return new List<List<string>>();

            Dictionary<string,List<string>> mapWord = new Dictionary<string,List<string>>();            

            foreach (string word in Arr)
            {
                char[] chars = word.ToCharArray();
                string sortedWord = new string(chars);
                if(mapWord.ContainsKey(sortedWord))
                {
                    mapWord[sortedWord].Add(word);
                }
                else
                    mapWord.Add(sortedWord, new List<string> { word });
            }

            return mapWord.Values.ToList();
        }

        static void Main(string[] args)
        {
            string[] Input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat"};


            List<List<string>> final = GroupAnagrams(Input);

            foreach (var item in final)
            {
                Console.Write($"[{string.Join(",", item)}");
            }

            Console.ReadLine();
        }
    }
}
