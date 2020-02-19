using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public class DeleteMiddleNode
    {
        public static void DeleteNode(ListNode node)
        {
            /*
             *   Delete Middle Node: Implement an algorithm to delete a node in the middle (i.e., any node but
             *   the first and last node, not necessarily the exact middle) of a singly linked list, given only access to
             *   that node.
             *   EXAMPLE
             *   Input: the node c from the linked list a - >b- >c - >d - >e- >f
             *   Result: nothing is returned, but the new linked list looks like a - >b- >d - >e- >f 
             */

            ListNode next = node.next;
            node.data = next.data;
            node.next = next.next;
            //DUH!

        }

        public class ListNode
        {
            public ListNode next;
            public char data;

            public ListNode(char val)
            {
                data = val;
                next = null;
            }

            public ListNode(char val, ListNode node)
            {
                data = val;
                next = node;
            }
        }
    }
}
