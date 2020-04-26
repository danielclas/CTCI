using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CTCI
{
    public static class PalindromePermutation
    {
        public static bool IsPermutation(string str)
        {
            /*
             * Given a string, write a function to check if it's a permutation of
             * a palindrome. A palindrome is a word or phrase that is the same
             * forwards or backward. A permutation is a rearrangement of letters.
             * The palindrome does not need to be limited to just dictionary words.
             */
            bool val = true;
            bool uneven = false;
            int spaces = 0;
            char[] arr = str.ToLower().ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var item in arr)
            {
                if (item!=' ')
                {
                    if (!dict.ContainsKey(item))
                    {
                        dict.Add(item, 1);
                    }
                    else
                    {
                        dict[item]++;
                    }
                }
                else
                {
                    spaces++;
                }               
            }

            foreach (var item in dict)
            {
                if (item.Key != ' ' && (item.Value == 1 || item.Value % 2 == 1))
                {
                    if (uneven)
                    {
                        val = false;
                        break;
                    }
                    else
                    {
                        uneven = true;
                    }
                }
            }

            if (uneven && arr.Length-spaces % 2 == 0)
            {
                val = false;
            }

            return val;

        }
    }
}
