using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter2.MyLinkedList<char>;

namespace Chapter2
{
    public static class LoopDetection
    {
        public static Node Detect(MyLinkedList<char> list)
        {
            /*
             *  Given a circular linked list, implement an algorithm that returns the node at the
             *  beginning of the loop.
             *  DEFINITION
             *  Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so
             *  as to make a loop in the linked list.
             *  EXAMPLE
             *  Input: A -> B -> C -> D -> E -> C (the same C as earlier)
             *  Output: C 
             */

            for (int i = list.Size; i >= 2; i--)
            {
                for (int k = i-1; k >=1 ; k--)
                {
                    if (ReferenceEquals(list.GetNode(i), list.GetNode(k)))
                    {
                        return list.GetNode(i);
                    }
                }
            }

            return null;
            
        }
    }
}
