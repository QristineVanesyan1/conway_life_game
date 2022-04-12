using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conway_life_game
{
    static class Example
    {
        internal static int[,] arr;
        internal static void InitPulsar(int size)
        {
            arr = new int[size, size];

            arr[4, 2] = 1;
            arr[4, 7] = 1;
            arr[4, 9] = 1;
            arr[4, 14] = 1;

            arr[5, 2] = 1;
            arr[5, 7] = 1;
            arr[5, 9] = 1;
            arr[5, 14] = 1;

            arr[6, 2] = 1;
            arr[6, 7] = 1;
            arr[6, 9] = 1;
            arr[6, 14] = 1;

            arr[10, 2] = 1;
            arr[10, 7] = 1;
            arr[10, 9] = 1;
            arr[10, 14] = 1;

            arr[11, 2] = 1;
            arr[11, 7] = 1;
            arr[11, 9] = 1;
            arr[11, 14] = 1;

            arr[12, 2] = 1;
            arr[12, 7] = 1;
            arr[12, 9] = 1;
            arr[12, 14] = 1;

            arr[2, 4] = 1;
            arr[2, 5] = 1;
            arr[2, 6] = 1;
            arr[2, 10] = 1;
            arr[2, 11] = 1;
            arr[2, 12] = 1;

            arr[7, 4] = 1;
            arr[7, 5] = 1;
            arr[7, 6] = 1;
            arr[7, 10] = 1;
            arr[7, 11] = 1;
            arr[7, 12] = 1;

            arr[9, 4] = 1;
            arr[9, 5] = 1;
            arr[9, 6] = 1;
            arr[9, 10] = 1;
            arr[9, 11] = 1;
            arr[9, 12] = 1;

            arr[14, 4] = 1;
            arr[14, 5] = 1;
            arr[14, 6] = 1;
            arr[14, 10] = 1;
            arr[14, 11] = 1;
            arr[14, 12] = 1;
        }

      
    }
}
