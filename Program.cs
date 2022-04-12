using System;
using System.Threading;

namespace conway_life_game
{
    class Program
    {
        static int size = 30;
        static void Show(int[,] arr)
        {
            Console.Clear();
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {

                    if (arr[i, j] != 0)
                    {
                        Console.Write($"*");
                    }
                    else
                    {
                        Console.Write($" ");
                    }
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        static int NeighborhoodCount(int[,] arr, int x, int y)
        {

            if (x == 0 || y == 0 || size == 4 || size == 4)
            {
                return 0;
            }

            return  arr[x - 1, y + 1] +
                    arr[x + 1, y - 1] +
                    arr[x - 1, y - 1] +
                    arr[x + 1, y + 1] + 
                    arr[x - 1, y] +
                    arr[x + 1, y] +
                    arr[x, y - 1] + 
                    arr[x, y + 1];
        }

        static void ConwayLifeCalculation(int[,] arr,int[,] temp,int i, int j, int count)
        {
            if (count <= 1)
            {
                temp[i, j] = 0;
            }

            if (count >= 4)
            {
                temp[i, j] = 0;
            }

            if (count == 2 || count == 3)
            {
                if (arr[i, j] == 1)
                {
                    temp[i, j] = 1;
                }
            }

            if (arr[i, j] == 0)
            {
                if (count == 3)
                {

                    temp[i, j] = 1;
                }
            }
        }
        static void Main(string[] args)
        {
            Example.InitPulsar(size);

            int[,] arr = Example.arr;
            int[,] temp = new int[size, size];

            while (true)
            {
                for (int j = 0; j < size-1; j++)
                {
                    for (int i = 0; i < size-1; i++)
                    { 
                        var count = NeighborhoodCount(arr, i, j);
                        ConwayLifeCalculation(arr,temp,i,j,count);
                    }
                }
               
               for (int j = 0; j < size; j++)
                {
                    for (int i = 0; i < size; i++)
                    {
                        arr[i, j] = temp[i, j];
                    }
                }

                Show(temp);
           }
        }
    }
}
