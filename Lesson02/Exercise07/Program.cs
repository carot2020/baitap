using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {2,1,2 },
                {1,1,1 },
                {4,5,6 }
            };

            int[,] b =
            {
                {4,5,6 },
                {2,3,4 },
                {1,2,3 }
            };

            int dist = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dist += a[i, j] * b[i, j];
                }

            }

            Console.WriteLine(dist);
        }
    }
}
