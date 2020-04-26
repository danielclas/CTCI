using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public static class StringRotation
    {
        public static bool IsRotation(string first, string second)
        {
            /*
             * Assume you have a method isSubstring which checks if one word is
             * a substring of another. Given two strings, s1 and s2, write code to check if s2 is
             * a rotation of s1 using only one call to isSubstring (e.g., "waterbottle" is a rotation
             * of "erbottlewat")
             */

            string s1 = SortString(first);
            string s2 = SortString(second);

            return s1.Contains(s2);
        }

        public static string SortString(string str)
        {
            char[] s = str.ToCharArray();
            Array.Sort(s);

            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                sb.Append(c);
            }            

            return sb.ToString();
        }
        
    }
}
