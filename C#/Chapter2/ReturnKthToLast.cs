using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public static class ReturnKthToLast
    {
        public static int KthToLast(int count, MyLinkedList<int> list)
        {
            /*
             * Implement an algorithm to find the Kth element from the last element
             * of a singly linked list.
             */

            int data = default(int);

            if (list.Size - count >= 1)
            {
                data = list.GetData(list.Size - count);
            }
            
            return data;
        }
    }
}
