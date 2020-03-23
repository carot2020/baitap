using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {5,6,7 },
                {8,9,10 }
            };

            int[,] b = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = a[ j,i];
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{a[j,i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
