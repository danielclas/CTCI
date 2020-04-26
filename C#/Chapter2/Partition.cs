using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public static class Partition
    {
        public static MyLinkedList<int> MakePartition(MyLinkedList<int> list, int value)
        {
            /*
             *  Write code to partition a linked list around a value x, such that all nodes less than x come
             *  before all nodes greater than or equal to x. lf x is contained within the list, the values of x only need
             *  to be after the elements less than x (see below). The partition element x can appear anywhere in the
             *  "right partition"; it does not need to appear between the left and right partitions.
             *  EXAMPLE
             *  Input: 3 -> 5 -> 8 -> 5 - > 10 -> 2 -> 1 [partition = 5)
             *  Output: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8 
             */

            MyLinkedList<int> before = new MyLinkedList<int>();
            MyLinkedList<int> after = new MyLinkedList<int>();

            for (int i = 1; i <= list.Size; i++)
            {
                if (list[i]<value)
                {
                    before.AddNode(list[i]);
                }
                else
                {
                    after.AddNode(list[i]);
                }
            }

            before.AppendList(after);

            return before;

        }
    }
}
