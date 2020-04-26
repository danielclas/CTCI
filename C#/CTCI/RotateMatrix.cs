using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public static class RotateMatrix
    {
        public static int[][] Rotate(int[][] matrix)
        {
            /*
             * Given an image represented by an NxN matrix, where each pixel
             * in the image is 4 bytes, write a method to rotate the image
             * by 90 degrees. Can you do this in place?
             */
            int[][] rotated = new int[4][];
            List<int> list = new List<int>();

            for (int i = 3, k = 0; i >= 0; i--, k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    list.Add(matrix[j][i]);
                }

                rotated[k] = list.ToArray();
                list.Clear();
            }

            return rotated;
        }
    }
}
