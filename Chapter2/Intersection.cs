using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter2.MyLinkedList<int>;

namespace Chapter2
{
    public static class Intersection
    {
        public static bool Intersect(MyLinkedList<int> list1, MyLinkedList<int> list2)
        {
            /*
             * Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting node. 
             * Note that the intersection is defined based on reference, not value. That is, if the kth
             * node of the first linked list is the exact same node (by reference) as the jth node of the second
             * linked list, then they are intersecting. 
             */

            Node node1, node2;

            for (int i = 1; i <= list1.Size; i++)
            {
                for (int k = 1; k <= list2.Size; k++)
                {
                    node1 = list1.GetNode(i);
                    node2 = list2.GetNode(k);

                    if (ReferenceEquals(node1,node2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
