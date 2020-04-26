using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public static class URLify
    {
        public static string Parse(string str)
        {
            /*
             * Write a method to replace all spaces in a string with '%20'.
             * You may assume that the string has sufficient space at the end to
             * hold the additional characters, and that you are given the true
             * length of the string.
             */

            char[] arr = str.TrimStart(' ').TrimEnd(' ').ToCharArray();
            StringBuilder rtn = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==' ')
                {
                    rtn.Append("%20");
                }
                else
                {
                    rtn.Append(arr[i]);
                }
            }

            return rtn.ToString();
        }
    }
}
