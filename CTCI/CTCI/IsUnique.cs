using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CTCI
{
    public static class IsUnique
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringCompression.Compress("aabccccaaa"));
            Console.ReadLine();
        }

        public static bool UniqueCharacters(string str)
        {
            /*
             Implement an algorithm to determine if a string has all unique characters.
             What if you cannot use additional data structures?
             */

            bool val = true;
            char[] arr = str.ToCharArray();
            Hashtable table = new Hashtable();

            foreach (var item in arr)
            {
                if (!table.ContainsKey(item))
                {
                    table.Add(item, 0);
                }
                else
                {
                    val = false;
                    break;
                }
            }

            return val;
        }


    }
}
