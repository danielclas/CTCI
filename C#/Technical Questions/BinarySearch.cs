using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Questions
{
    public static class BinarySearch
    { 
        public static int Search(int[] arr, int target)
        {
            int lower = 0;
            int upper = arr.Length - 1;
            int middle;

            while (lower <= upper)
            {
                middle = (lower + upper) / 2;
                if (arr[middle] == target)
                {
                    return middle;
                }else if (target > arr[middle])
                {
                    lower = middle+1;
                }
                else
                {
                    upper = middle-1;
                }
            }

            return -1;
        }
    }
}
