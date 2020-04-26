using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public static class Palindrome
    {
        public static bool IsPalindrome(MyLinkedList<char> list)
        {
            /*
             * Implement a function to check if a linkedlist is palindrome.
             */

            bool p = true;
            bool uneven = list.Size % 2 == 1;

            if (list.Size != 2)
            {
                for (int i = 1, k = list.Size; i <= list.Size / 2; i++, k--)
                {
                    if (list[i].CompareTo(list[k]) != 0)
                    {
                        p = false;
                        break;
                    }
                }
            }

            return p;
        }
    }
}
