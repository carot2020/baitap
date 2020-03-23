using System;

namespace Exercise08
{
    class Program
    {

        static int dotProduct(int[,]a, int[,] b)
        {
            int dist = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dist += a[i, j] * b[i, j];
                }

            }
            return dist;
        }

        static int[,] layMatranCon(int[,]a, int k)
        {
            int[,] b = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for(int j=0; j < k; j++)
                {
                    b[i, j] = a[i, j];
                }
            } 
            return b;
        }

        static void Main(string[] args)
        {
            int[,] input =
          {
                {4,2,2,4 },
                {1,9,5,3 },
                {1,4,2,4 },
                {0,9,8,1 }
            };

            int[,] kernel =
            {
                {-1,-1,-1 },
                {-1,8,-1 },
                {-1,-1,-1 }
            };

            int i, j, m, n, mm, nn;
            int kCenterX, kCenterY; // center index of kernel
            int sum; // temp accumulation buffer
            int rowIndex, colIndex;
            kCenterX = kernel.GetLength(0) / 2;
            kCenterY = kernel.GetLength(1) / 2;

            for (i = 0; i < input.GetLength(0); ++i) // rows
            {
                for (j = 0; j < input.GetLength(1); ++j) // columns
                {
                    sum = 0; // init to 0 before sum
                    for (m = 0; m < kernel.GetLength(0); ++m)
                    {
                        mm = kernel.GetLength(0) - 1 - m; // row index of flipped kernel
                        for (n = 0; n < kernel.GetLength(1); ++n)
                        {
                            nn = kernel.GetLength(1) - 1 - n;
                            rowIndex = i + (kCenterY - mm);
                            colIndex = j + (kCenterX - nn);

                            if (rowIndex >= 0 && rowIndex < input.GetLength(0) && colIndex >= 0 && colIndex < input.GetLength(1))
                            {

                                
                            }
    }
                        }// kernel columns
                    }// kernel rows
                }

            }
        }
    }
}
