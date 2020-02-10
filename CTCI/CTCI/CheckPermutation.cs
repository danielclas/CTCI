using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CTCI
{
    public static class CheckPermutation
    {
        public static bool Check(string first, string second)
        {
            /*
             * Given two strings, write a method to decide if one is a
             * permutation of the other.
             */

            bool val = true;
            List<char> list = new List<char>(first.ToCharArray());
            List<char> list2 = new List<char>(second.ToCharArray());

            if (list.Count != list2.Count)
            {
                val = false;
            }
            else
            {
                list.Sort();
                list2.Sort();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != list2[i])
                    {
                        val = false;
                        break;
                    }
                }
            }
            
            return val;
        }
    }
}
