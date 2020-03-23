using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 4 ,2};
            int[,] b =
            {
                {12, 15, 11, 10 },
                {32, 30, 40, 23 },
                {13, 12, 20, 15 }
            };
            int[] c = new int[b.GetLength(1)];

            for(int j= 0; j< b.GetLength(1); j++)
            {
                int sum = 0;
                for (int i=0; i<b.GetLength(0); i++)
                {
                    sum += (a[i] * b[i, j]);
                }
                c[j] = sum;
            }

            for(int k = 0; k < c.Length; k++)
            {
                Console.Write($"{c[k]} ");
            }
        }
    }
}
