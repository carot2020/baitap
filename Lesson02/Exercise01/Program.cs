using System;

namespace Exercise01
{
    class Program
    {

        static void nhapMang2Chieu(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                string[] token1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(token1[j]);
                }
            }
        }

        static void xuatMang2Chieu(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("Row " + i + ":"  );
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int n = int.Parse(token[0]);
            int m = int.Parse(token[1]);
            int[,] a = new int[n, m];

            nhapMang2Chieu(a, n, m);
            xuatMang2Chieu(a);
         


            Console.ReadLine();
        }
    }
}
