using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int n = int.Parse(token[0]);
            int x = int.Parse(token[1]);
            
            int[] a = new int[n];
            string[] token2 = Console.ReadLine().Split(' ');
            if(token2.Length == n)
            {
                for(int i=0; i<n; i++)
                {
                    a[i] = int.Parse(token2[i]);
                }

                int j = 0;
                while (a[j] != x)
                {
                    j++;
                }
                if (j < n) Console.WriteLine("Yes");
                else Console.WriteLine("No");

            }

            
        }
    }
}
