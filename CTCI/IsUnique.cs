using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CTCI
{
    public static class IsUnique
    {
        static void Main(string[] args)
        {
            int[][] test1 = new int[4][];
            test1[0] = new int[] { 1, 2, 3, 4 };
            test1[1] = new int[] { 5, 6, 7, 8 };
            test1[2] = new int[] { 9, 10, 11, 12 };
            test1[3] = new int[] { 13, 14, 15, 16 };

            int[][] success1 = RotateMatrix.Rotate(test1);

            StringBuilder t = new StringBuilder();
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    t.Append(test1[i][j]);
                    s.Append(success1[i][j]);
                }

                t.AppendLine(" ");
                s.AppendLine(" ");
            }

            Console.WriteLine(t);
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static bool UniqueCharacters(string str)
        {
            /*
             Implement an algorithm to determine if a string has all unique characters.
             What if you cannot use additional data structures?
             */

            bool val = true;
            char[] arr = str.ToCharArray();
            Hashtable table = new Hashtable();

            foreach (var item in arr)
            {
                if (!table.ContainsKey(item))
                {
                    table.Add(item, 0);
                }
                else
                {
                    val = false;
                    break;
                }
            }

            return val;
        }


    }
}
