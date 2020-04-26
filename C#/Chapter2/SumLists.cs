using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public static class SumLists
    {
        public static MyLinkedList<char> Sum(MyLinkedList<char> list1, MyLinkedList<char> list2)
        {
            /*
             * You have two numbers represented by a linked list, where each node
             * contains a single digit. The digits are stored in reverse order, such that the 1's
             * digit is at the head of the list. Write a function that adds the two numbers
             * and returns the sum as a linked list.
             * 
             * Example: 
             * Input: (7->1->6) + (5->9->2). That is, 617+295.
             * Output: 2->1->9. That is, 912.
             */

            MyLinkedList<char> result;

            StringBuilder n1 = new StringBuilder();
            StringBuilder n2 = new StringBuilder();
            string sum;

            int int1, int2, size;
            size = list1.Size > list2.Size ? list1.Size : list2.Size;

            for (int i = size; i >= 1; i--)
            {
                if (!ReferenceEquals(list1[i], null))
                {
                    n1.Append(list1[i]);
                }

                if (!ReferenceEquals(list2[i], null))
                {
                    n2.Append(list2[i]);
                }
            }

            int1 = int.Parse(n1.ToString());
            int2 = int.Parse(n2.ToString());

            sum = (int1 + int2).ToString();

            result = new MyLinkedList<char>();

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                result.AddNode(sum[i]);
            }

            return result;
        }
    }
}
