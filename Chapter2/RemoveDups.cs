using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public static class RemoveDups
    {
        public static void RemoveDuplicates(MyLinkedList<int> list)
        {
            if (list.Size != 1)
            {
                for (int i = 1; i <= list.Size; i++)
                {
                    for (int k = i + 1; k <= list.Size; k++)
                    {
                        if (list.GetData(i) == list.GetData(k))
                        {
                            list.RemoveNode(k);
                            k--;
                        }
                    }

                }
            }
        }
    }
}
