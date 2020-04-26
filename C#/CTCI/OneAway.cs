using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public static class OneAway
    {
        public static bool Check(string first, string second)
        {
            /*
             * There are three types of edits that can be performed on strings:
             * insert a character, remove a character, or replace a character.
             * Given two strings, write a function to check if they are one edit
             * or zero edits away.
             */

            int count = 0;
            int diff = first.Length - second.Length;
            string shorter, longer;

            first = first.ToLower();
            second = second.ToLower();

            if (first.Length < second.Length)
            {
                shorter = first;
                longer = second;
            }
            else
            {
                shorter = second;
                longer = first;
            }

            if (diff >= 2 || diff <= -2)
            {
                return false;
            }
            else
            {
                for (int i = 0, k = 0; i < shorter.Length; i++, k++)
                {
                    if (shorter[i] != longer[k])
                    {
                        if (count == 1)
                        {
                            return false;
                        }
                        else
                        {
                            if (diff == 0)
                            {
                                shorter = shorter.Remove(i, 1);
                            }

                            longer = longer.Remove(k, 1);
                            k--;
                            i--;
                            count++;
                        }
                    }
                }
            }

            if (count == 1 && shorter.Length != longer.Length)
            {
                return false;
            }

            return count == 1 || count == 0;
        }
    }
}
