using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = {
                {2, 3, 4 },
                {5, 6, 7 }
            };
            int[,] b =
            {
                {4, 5, 6 },
                {7, 8, 9 }
            };

            int[,] c = new int[2, 3];
            for(int i = 0; i< 2; i++)
            {
                for(int j=0; j <3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
