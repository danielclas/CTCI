using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Questions
{
    public static class MergeSort
    {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count == 1)
            {
                return list;
            }

            var l1 = list.GetRange(0, list.Count / 2);
            var l2 = list.GetRange(list.Count / 2, list.Count - list.Count/2);

            l1 = Sort(l1);
            l2 = Sort(l2);

            return Merge(l1, l2);
        }

        public static List<int> Merge(List<int> l1, List<int> l2)
        {
            List<int> c = new List<int>();

            while (l1.Count != 0 && l2.Count != 0)
            {
                if (l1[0] > l2[0])
                {
                    c.Add(l2[0]);
                    l2.RemoveAt(0);
                }
                else
                {
                    c.Add(l1[0]);
                    l1.RemoveAt(0);
                }
            }

            while (l1.Count != 0)
            {
                c.Add(l1[0]);
                l1.RemoveAt(0);
            }

            while (l2.Count != 0)
            {
                c.Add(l2[0]);
                l2.RemoveAt(0);
            }

            return c;
        }
    }
}
