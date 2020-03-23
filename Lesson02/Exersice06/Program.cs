using System;
using System.Globalization;

namespace Exersice06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {4,5 },
                {6,7 }
            };

            int[,] b =
            {
                {2,5 },
                {8,1 }
            };
            double dist=0.0;
            for (int i=0; i<2; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    dist += Math.Pow(a[i, j] - b[i, j], 2);
                }
                
            }
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                                "{0:0.00}", Math.Sqrt(dist)));
            //Console.WriteLine(dist);
        }
    }
}
