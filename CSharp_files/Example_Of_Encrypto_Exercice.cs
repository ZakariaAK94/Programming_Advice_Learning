using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOdEncryptoExo
{
    internal class Program
    {
        public static string EncryptWithStringBuilder(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("Input cannot be null or empty");
            }

            StringBuilder result = new StringBuilder(); // Length of word + length of "aca"

            for (int i = word.Length - 1; i >= 0; i--)
            {
                char ch = word[i];
                switch (ch)
                {
                    case 'a':
                    case 'A':
                        result.Append('0');
                        break;
                    case 'e':
                    case 'E':
                        result.Append('1');
                        break;
                    case 'i':
                    case 'I':
                        result.Append('2');
                        break;
                    case 'o':
                    case 'O':
                        result.Append('3');
                        break;
                    case 'u':
                    case 'U':
                        result.Append('4');
                        break;
                    default:
                        result.Append(ch);
                        break;
                }
            }

            result.Append("aca");
            return result.ToString();
        }
        static void Main(string[] args)
        {

            string word = "zakaria";
            Console.WriteLine(EncryptWithStringBuilder(word));
            Console.ReadKey();
        }
    }

}
