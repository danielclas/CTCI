using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public static class StringCompression
    {
        public static string Compress(string str)
        {
            int count = 1;
            int k = 1;
            StringBuilder val = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                for (; k < str.Length; k++)
                {
                    if (str[i] == str[k])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                val.Append(str[i] + count.ToString());
                count = 1;
                i = k - 1;
                k++;
            }

            return val.Length < str.Length ? val.ToString() : str;
        }
    }
}
