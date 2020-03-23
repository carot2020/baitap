using System;

/*
 *  MathNet.Numerics
            Matrix<double> a = DenseMatrix.OfArray(new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            Matrix<double> b = DenseMatrix.OfArray(new double[,] { { 1 }, { 2 }, { 3 } });
            Matrix<double> result = a * b;
 * 
 */

namespace Exercise04
{
    class Program
    {

        public static void xuatMang2Chieu(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void nhanMatrix(int[,]a, int[,] b)
        {
           
            if (a.GetLength(1) == b.GetLength(0))
            {
               int[,] c = new int[a.GetLength(0), b.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++) // OR k<b.GetLength(0)
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
                }

                xuatMang2Chieu(c);
            }
            else
            {
                Console.WriteLine("\n Number of columns in First Matrix should be equal to Number of rows in Second Matrix.");
                Console.WriteLine("\n Please re-enter correct dimensions.");
                Environment.Exit(-1);
            }
        }
        static void Main(string[] args)
        {
            int[,] a =
            {
                {1, 2 },
                {3, 4 }

            };
            int[,] b =
            {
                {5, 6, 7 },
                {8, 9, 10 }
            };
           
            nhanMatrix(a, b);
            
        }
    }
}
